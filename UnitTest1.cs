using MSUnitTesting;

namespace LogicalUnitTesting
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void IsPrimeOrNot_ReturnsTrue()
        {

            //AAA
           
            LogicalExecution logic1=new LogicalExecution();

            //Arrange
            int number = 7;

            //Act
             bool result=logic1.IsPrimeOrNot(number);

            //Assert
            Assert.IsTrue(result);


        }


        [TestMethod]
        public void IsPrimeOrNot_ReturnsFalse()
        {

            //AAA

            LogicalExecution logic1 = new LogicalExecution();

            //Arrange
            int number = 9;

            //Act
            bool result = logic1.IsPrimeOrNot(number);

            //Assert
            Assert.IsFalse(result);


        }

        [TestMethod]
        public void IsAnagram_ReturnsTrue()
        {
            LogicalExecution logic1=new LogicalExecution();

            //Arrange
            string st1 = "santhosh kumar";
            string st2 = "santhosh kumar";

            //Act
            bool res = logic1.IsAnagram(st1, st2);

            //Assert
           Assert.IsTrue(res);

        }
       
    }
}