using Microsoft.VisualStudio.TestTools.UnitTesting;
using Grades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades.Tests
{
    [TestClass]
    public class GradeBookTest
    {
        [TestMethod]
        public void UppercaseString()
        {
            string name = "scott";
            //tengo que asignarle la referencia para que funcione si no no vana ser iguales
            //es porque son inmutables y el valor nunca cambia
            // hay que tener cuidado porque los metodos que se hacen pueden que no cambien el
            //valor ya que solo devuelven la intacnia pero no lo cambian  
            name = name.ToUpper();

            Assert.AreEqual("SCOTT", name);
        }

        [TestMethod]
        public void AddGradesToDateTime()
        {
            DateTime date = new DateTime(2015, 1, 1);
            //date.AddDays(1); asi va fallar
            //hay que asignarselo
            date = date.AddDays(1);

            Assert.AreEqual(2, date.Day);

        }
        [TestMethod]
        public void ComputesHighestGrade()
        {
            GradeBook book = new GradeBook();
            book.AddGrade(10);
            book.AddGrade(90);

            GradeStatistics result = book.ComputeStatistics();
            Assert.AreEqual(90, result.HighestGrade);
        }

        [TestMethod]
        public void ComputesLowestGrade()
        {
            GradeBook book = new GradeBook();
            book.AddGrade(10);
            book.AddGrade(90);

            GradeStatistics result = book.ComputeStatistics();
            Assert.AreEqual(10, result.LowestGrade);
        }

        [TestMethod]
        public void ComputesAveregeGrade()
        {
            GradeBook book = new GradeBook();
            book.AddGrade(91);
            book.AddGrade(85.5f);
            book.AddGrade(75);

            GradeStatistics result = book.ComputeStatistics();
            Assert.AreEqual(83.83, result.AverageGrade, 0.01);
        }
    }
}
