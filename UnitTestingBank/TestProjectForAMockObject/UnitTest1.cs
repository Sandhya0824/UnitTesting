using MockObject;
using MockObject.Controllers;
using Moq;

namespace TestProjectForAMockObject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var mockObject = new Mock<IGetDataDatabase>();
            mockObject.Setup(p => p.GetNameById(3)).Returns("Sandhya");
            HomeController home = new HomeController(mockObject.Object);
            string result = home.GetNameById(3);
            Assert.AreEqual("Sandhya", result);
        }
    }
}