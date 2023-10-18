namespace ChallengeApka.Tests
{
    public class Tests
    {
        [Test]
        public void WhenUserCollectTwoSetOfPoints_ShouldReturnCorrectResult()
        { //arrange

            var employee = new Employee("Damian", "Fio³ek1");
            employee.AddScore(1);
            employee.AddScore(-8);
            //act
            var result = employee.Result;
            // assert


            Assert.AreEqual(-7, result);
        }
    }

}