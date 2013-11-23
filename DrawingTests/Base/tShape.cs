using DrawingLib.Base;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace DrawingLibUnitTests.Base{
    [TestClass]
    public class tShape : Shape{
        [TestMethod]
        public void Shape_WhenConstructedParameterlessly_IsIntstantaited() { 
            //Arrange: a pointer to a shape is declared.
            Shape shape;

            //Act: The shape is instantiated.
            shape = new Shape();

            //Assert: The pointer now references an instance.
            Assert.AreNotEqual(null, shape);
        }
    }
}
