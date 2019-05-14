using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LinqQueries;

namespace EmployeeExtensionsWrong
{
    public static class EmployeeExtensions
    {
        public static IEnumerable<Employee> Where(
                                           this IEnumerable<Employee> sequence, 
                                           Func<Employee, bool> predicate)
        {
            List<Employee> list = new List<Employee>();
            foreach(Employee employee in sequence)
            {
                if (predicate(employee))
                {
                    list.Add(employee);
                }
            }
            return list;
        }
    }
}

namespace EmployeeExtensions
{
    public static class EmployeeExtensions
    {
        public static IEnumerable<Employee> Where(
                                           this IEnumerable<Employee> sequence,
                                           Func<Employee, bool> predicate)
        {
            foreach (Employee e in sequence)
            {
                if (predicate(e))
                {
                    yield return e;
                }
            }
        }
    }
}