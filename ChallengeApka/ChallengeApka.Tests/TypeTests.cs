using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeApka.Tests
{
    public class TypeTests
    {
        [Test]
        public void TEST()
        { //arrange
           int number1 = 1;
           int number2 = 1;

            //act

            // assert
            Assert.AreEqual(number1, number2);  


        }
       
        private Employee GetUser(string imie)
        {
            return new Employee(imie);
        }
    }
}
