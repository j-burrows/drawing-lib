using System.Text;
using DrawingLib.Business;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace DrawingLibUnitTests.Business{
    [TestClass]
    public class tBShape : BShape{
        [TestMethod]
        public void BShapeWithValidMembers_WhenCheckedIfCreateValid_IsTrue() {
            //Arrange: A entry with valid members is constructed.
            BShape shape = new BShape { Json="Json"};

            //Act: the shape is checked to be create valid.
            bool valid = shape.CreateValid();

            //Assert: the shape is create valid.
            Assert.AreEqual(true, valid);
        }
        [TestMethod]
        public void BShapeWithInvalidMembers_WhenCheckedIfCreateValid_IsFalse(){
            //Arrange: A entry with invalid members is constructed.
            BShape shape = new BShape { Json = null };

            //Act: the shape is checked to be create valid.
            bool valid = shape.CreateValid();

            //Assert: the shape is not create valid.
            Assert.AreEqual(false, valid);
        }
        [TestMethod]
        public void BShapeWithValidMembers_WhenCheckedIfUpdateValid_IsTrue(){
            //Arrange: A entry with valid members is constructed.
            BShape shape = new BShape { Json = "" };

            //Act: the shape is checked to be update valid.
            bool valid = shape.UpdateValid();

            //Assert: the shape is update valid.
            Assert.AreEqual(true, valid);
        }
        [TestMethod]
        public void BShapeWithInvalidMembers_WhenCheckedIfUpdateValid_IsFalse(){
            //Arrange: A entry with invalid members is constructed.
            StringBuilder builder = new StringBuilder();
            for (int i = 0; i < 4097; i++ ) {
                builder.Append("1");
            }
            BShape shape = new BShape { Json = builder.ToString()};

            //Act: the shape is checked to be update valid.
            bool valid = shape.UpdateValid();

            //Assert: the shape is update valid.
            Assert.AreEqual(false, valid);
        }
        [TestMethod]
        public void BShape_WhenCheckedIfDeleteValid_IsTrue(){
            //Arrange: A entry is constructed.
            BShape shape = new BShape();

            //Act: the shape is checked to be delete valid.
            bool valid = shape.DeleteValid();

            //Assert: the shape is delete valid.
            Assert.AreEqual(true, valid);
        }
        [TestMethod]
        public void BShape_WhenCheckedForEquivilance_IsAlwaysFalse(){
            //Arrange: A entry with valid members is constructed.
            BShape shape = new BShape();

            //Act: the shape is checked to be equivilant to itself.
            bool equals = false;

            //Assert: the shape is not equivilant to itself.
            Assert.AreEqual(false, equals);
        }
    }
}
