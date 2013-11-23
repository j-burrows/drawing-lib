using DrawingLib.Presentation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace DrawingLibUnitTests.Presentation{
    [TestClass]
    public class tPImage : PImage{
        [TestMethod]
        public void PImageWithNullMembers_WhenFormatted_BecomeEmptyMembers() { 
            //Arrange: An image is constructed with all possible null members.
            PImage image = new PImage { username = null, Title = null, shapes = null};

            //Act: The image is formatted.
            image.Format();

            //Assert: all null members are now empty
            Assert.AreNotEqual(null, image.username);
            Assert.AreNotEqual(null, image.Title);
            Assert.AreNotEqual(null, image.shapes);
        }
    }
}
