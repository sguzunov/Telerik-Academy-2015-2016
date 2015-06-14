﻿using System;
using System.Linq;
using System.Text;
using System.CodeDom.Compiler;
using Microsoft.CSharp;
using System.Reflection;
using System.Collections.Generic;
using System.Collections;

namespace SoftwareAcademy
{
    public class Teacher : ITeacher
    {
        private string name;
        private ICollection<ICourse> courses;

        public Teacher(string name)
        {
            this.Name = name;
            courses = new List<ICourse>();
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {               
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Incorrect input data.The name CANNOT be null or empty string.");
                }

                this.name = value;
            }
        }

        public void AddCourse(ICourse course)
        {
            if (course == null)
            {
                throw new ArgumentNullException("Incorrect input data.You should add a course");
            }

            this.courses.Add(course);
        }

        public override string ToString()
        {
            StringBuilder output = new StringBuilder();

            output.AppendFormat("Teacher: Name={0}", this.Name);

            if (this.courses.Count > 0)
            {
                output.AppendFormat("; Courses=[{0}]", string.Join(", ", this.courses.Select(cs => cs.Name)));
            }

            return output.ToString();
        }
    }
            
    public interface ITeacher
    {
        string Name { get; set; }
        void AddCourse(ICourse course);
        string ToString();
    }

    public abstract class Course : ICourse
    {
        private string name;
        private ICollection<string> topics;

        public Course(string name,ITeacher techer)
        {
            this.Name = name;
            topics = new List<string>();
            this.Teacher = techer;
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Incorrect input data.The name CANNOT be null or empty string.");
                }

                this.name = value;
            }
        }

        public ITeacher Teacher { get; set; }

        public void AddTopic(string topic)
        {
            if (string.IsNullOrEmpty(topic))
            {
                throw new ArgumentNullException("Incorrect input data.The name CANNOT be null or empty string.");
            }

            this.topics.Add(topic);
        }

        public override string ToString()
        {
            StringBuilder output = new StringBuilder();

            output.AppendFormat("{0}: Name={1}", this.GetType().Name, this.Name);
          
            if (this.Teacher != null)
            {
                output.AppendFormat("; Teacher={0}", this.Teacher.Name);
            }
            if (this.topics.Count > 0)
            {
                output.AppendFormat("; Topics=[{0}]", string.Join(",", this.topics));
            }

            return output.ToString();
        }        
    }

    public interface ICourse
    {
        string Name { get; set; }
        ITeacher Teacher { get; set; }
        void AddTopic(string topic);
        string ToString();
    }

    public class LocalCourse : Course, ILocalCourse
    {
        private string lab;

        public LocalCourse(string lab,ITeacher teacher, string name)
            : base(name,teacher)
        {
            this.Lab = lab;
        }

        public string Lab
        {
            get
            {
                return this.lab;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Incorrect input data.The lab CANNOT be null or empty string.");
                }

                this.lab = value;
            }
        }

        public override string ToString()
        {
            StringBuilder output = new StringBuilder(base.ToString());

            output.AppendFormat("; Lab={0}", this.Lab);

            return output.ToString();
        }
    }

    public interface ILocalCourse : ICourse
    {
        string Lab { get; set; }
    }

    public class OffsiteCourse : Course, IOffsiteCourse
    {
        private string town;

        public OffsiteCourse(string town, ITeacher teacher, string name)
            : base(name, teacher)
        {
            this.Town = town;
        }

        public string Town
        {
            get
            {
                return this.town;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Incorrect input data.The town CANNOT be null or empty string.");
                }

                this.town = value;
            }
        }

        public override string ToString()
        {
            StringBuilder output = new StringBuilder(base.ToString());

            output.AppendFormat("; Town={0}", this.Town);

            return output.ToString();
        }
    }

    public interface IOffsiteCourse : ICourse
    {
        string Town { get; set; }
    }

    public interface ICourseFactory
    {
        ITeacher CreateTeacher(string name);
        ILocalCourse CreateLocalCourse(string name, ITeacher teacher, string lab);
        IOffsiteCourse CreateOffsiteCourse(string name, ITeacher teacher, string town);
    }

    public class CourseFactory : ICourseFactory
    {
        public ITeacher CreateTeacher(string name)
        {
            return new Teacher(name);
        }

        public ILocalCourse CreateLocalCourse(string name, ITeacher teacher, string lab)
        {
            return new LocalCourse(lab, teacher, name);
        }

        public IOffsiteCourse CreateOffsiteCourse(string name, ITeacher teacher, string town)
        {
            return new OffsiteCourse(town, teacher, name);
        }
    }

    public class SoftwareAcademyCommandExecutor
    {
        static void Main()
        {
            string csharpCode = ReadInputCSharpCode();
            CompileAndRun(csharpCode);
        }

        private static string ReadInputCSharpCode()
        {
            StringBuilder result = new StringBuilder();
            string line;
            while ((line = Console.ReadLine()) != "")
            {
                result.AppendLine(line);
            }
            return result.ToString();
        }

        static void CompileAndRun(string csharpCode)
        {
            // Prepare a C# program for compilation
            string[] csharpClass =
            {
                @"using System;
                  using SoftwareAcademy;

                  public class RuntimeCompiledClass
                  {
                     public static void Main()
                     {"
                        + csharpCode + @"
                     }
                  }"
            };

            // Compile the C# program
            CompilerParameters compilerParams = new CompilerParameters();
            compilerParams.GenerateInMemory = true;
            compilerParams.TempFiles = new TempFileCollection(".");
            compilerParams.ReferencedAssemblies.Add("System.dll");
            compilerParams.ReferencedAssemblies.Add(Assembly.GetExecutingAssembly().Location);
            CSharpCodeProvider csharpProvider = new CSharpCodeProvider();
            CompilerResults compile = csharpProvider.CompileAssemblyFromSource(
                compilerParams, csharpClass);

            // Check for compilation errors
            if (compile.Errors.HasErrors)
            {
                string errorMsg = "Compilation error: ";
                foreach (CompilerError ce in compile.Errors)
                {
                    errorMsg += "\r\n" + ce.ToString();
                }
                throw new Exception(errorMsg);
            }

            // Invoke the Main() method of the compiled class
            Assembly assembly = compile.CompiledAssembly;
            Module module = assembly.GetModules()[0];
            Type type = module.GetType("RuntimeCompiledClass");
            MethodInfo methInfo = type.GetMethod("Main");
            methInfo.Invoke(null, null);
        }
    }
}
