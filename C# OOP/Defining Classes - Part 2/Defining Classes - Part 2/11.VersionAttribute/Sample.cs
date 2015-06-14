namespace AttributeVersion
{
    using System;

    [AttributeUsage(AttributeTargets.Struct | AttributeTargets.Method |
                  AttributeTargets.Class | AttributeTargets.Interface|
                  AttributeTargets.Enum,AllowMultiple = true)]

    public class VersionAttribute : Attribute
    {
        public string Version { get; private set; }

        public VersionAttribute(string version)
        {
            this.Version = version;
        }
    }

    [Version("2.11")]
    class SampleAttribute
    {
        static void Main()
        {
            Type type = typeof(SampleAttribute);
            object[] allAttributes = type.GetCustomAttributes(false);

            foreach (VersionAttribute attribute in allAttributes)
            {
                Console.WriteLine(attribute.Version);
            }
        }
    }


    // Create a [Version] attribute that can be applied to structures, classes, interfaces, enumerations and methods and holds
   //  a version in the format major.minor (e.g. 2.11).
  //Apply the version attribute to a sample class and display its version at runtime.

}