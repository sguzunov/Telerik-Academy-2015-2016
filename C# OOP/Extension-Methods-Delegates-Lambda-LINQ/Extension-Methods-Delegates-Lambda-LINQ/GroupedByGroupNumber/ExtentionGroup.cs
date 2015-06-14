namespace GroupedByGroupNumber
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.Linq;

    public static class ExtentionGroup
    {
        public static IEnumerable<Students> OrderByGroupName(this List<Students> students)  // problem 19
        {
            var result = students.OrderBy(st => st.GroupName);

            return result;
        }

    }
}
