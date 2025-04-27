using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace lorena_task
{
    [TestFixture]
    internal class TestResultCalculate
    {
        [TestCaseSource(nameof(test_datas))]
        public void TestCalculate(string select,decimal price, decimal resultExpected) {
            //инициализация объекта тестирования
            Form1 form1 = new Form1();
            form1.SetPrice(price);
            form1.SelectNode(select);
            //воздействие на объект тестирования
            decimal actual = form1.Calculate();
            //проверка результата
            Assert.That(actual, Is.EqualTo(resultExpected));
        }

        public static object[] test_datas ={
            new object[] { "Миасс",  57470.00m,     55171.20m },
            new object[] { "Амелия", 5360.00m,      4877.60m },
            new object[] { "Тест1",  136540.00m,    121520.60m },
            new object[] { "Тест2",  54054.00m,     51891.84m },
            new object[] { "Курган", 57850.00m,     51486.50m }
        };
    }
}
