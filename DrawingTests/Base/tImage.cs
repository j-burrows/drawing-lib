using DrawingLib.Base;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace DrawingLibUnitTests.Base{
    [TestClass]
    public class tImage : Image{
        [TestMethod]
        public void Image_WhenConstructedParamaterlessly_IsInstantiated() { 
            //Arrange: A pointer to an image is declared.
            Image image;

            //Act: The image is instantiated without parameters.
            image = new Image();

            //Assert: the image pointer is no longer null.
            Assert.AreNotEqual(null, image);
        }
    }
}
