using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeApka.Tests
{
    public class TypeTests2
    {
        [Test]
        public void TEST2()
        { //arrange
            float number1 = 111;
            float number2 = 111;

            //act

            // assert
            Assert.AreEqual(number1, number2);


        }

    }

}