using DemoWebApp.BusinessLogic;

namespace DemoWebApp.UnitTest
{
    public class UnitTest1
    {
        [Fact]
        public void HelperSum_ShouldReturnCorrectValue()
        {
            Assert.True(Helper.Sum(1, 2) == 3);
        }
    }
}