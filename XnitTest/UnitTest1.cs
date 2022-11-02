using System.ComponentModel;
using MyNamespace;
using Newtonsoft.Json.Linq;
using Xunit.Sdk;

//t
namespace XUnitTest
{
    //product branch is created

   
    public class UnitTest1
    {
        //instance variable used just for Multiply test method
        public Calculator calc = new Calculator();

        [Fact]
        public void Add()
        {
            Calculator cal = new Calculator();

           
            int ActualValue  = cal.add(20, 10);
            int ExpectedValue = 30;

           
            Assert.Equal(ExpectedValue, ActualValue);
        }

         [Fact]
        public void Subtract()
        {
            Calculator cal = new Calculator();

            int AcualValue = cal.Subtract(20, 10);
            int ExpectedValue = 10;

            Assert.Equal(AcualValue,ExpectedValue);
        }

        [Fact]
        public void Multyply()
        {
            int AcualValue = calc.Multiply(20, 10);
            int ExpectedValue = 200;

            Assert.Equal(ExpectedValue , AcualValue);

        }

        /* TeamCity
        [Fact]
        public void Division()
        {
            int AcualValue = calc.Division(50, 5);
            int ExpectedValue = 10;

            Assert.Equal(AcualValue,ExpectedValue);
        }
        */
    }
}