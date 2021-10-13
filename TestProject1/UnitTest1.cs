using Microsoft.VisualStudio.TestTools.UnitTesting;
using UC1FirstName;


namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        [ExpectedException(typeof(CustomException))]
        public void ValidateFirstName()
        {
            //Arrange
            ChkFirstName obj = new ChkFirstName();

            string expected = "Invalid FirstName";

            //Act
            var result = obj.Validate(null);


            //Assert
            Assert.AreEqual(expected, result);
        }
    }
}
