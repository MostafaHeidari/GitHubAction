using System.ComponentModel;
using MyNamespace;
using Newtonsoft.Json.Linq;
using Xunit.Sdk;

//t
namespace XUnitTest
{
    // crud branch is created.

    //new product is created from CRUD branch.

    ////new product is created from CRUD branch.333333333333333333333
    ////new product is created from CRUD branch.4444444444444444444444444444444444444444444444
    ///
    /// ////new product is created from CRUD branch.5555555555555555555555555555555555555
    ///
    /// last pushhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhh7777777777777777777777777
    /// all right now 
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