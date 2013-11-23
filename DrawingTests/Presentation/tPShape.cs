using DrawingLib.Presentation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace DrawingLibUnitTests.Presentation{
    [TestClass]
    public class tPShape : PShape{
        [TestMethod]
        public void PShapeWithNullMembers_WhenFormatted_BecomeEmptyMembers(){
            //Arrange: A shape is constructed with all possible null members.
            PShape shape = new PShape { Json = null};

            //Act: the shape is formatted.
            shape.Format();

            //Assert: the shape no longer has null members.
            Assert.AreNotEqual(null, shape.Json);
        }
    }
}
