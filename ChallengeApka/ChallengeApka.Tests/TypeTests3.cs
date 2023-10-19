using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeApka.Tests
{
    public class TypeTests3
    {
        [Test]
        public void TEST3()
        { //arrange
          string imie1 = "Adam";
          string imie2 = "Adam";

            //act

            // assert
            Assert.AreEqual(imie1, imie2);


        }

    }

}