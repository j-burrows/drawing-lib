using DrawingLib.Business;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace DrawingLibUnitTests.Business{
    [TestClass]
    public class tBImage : BImage{
        [TestMethod]
        public void BImageWithValidMembers_WhenCheckedIfCreateValid_IsTrue(){
            //Arrange: A entry with valid members is constructed.
            BImage image = new BImage { username="username", Title="Title"};
            image.Format();

            //Act: the image is checked to be create valid.
            bool valid = image.CreateValid();

            //Assert: the image is create valid.
            Assert.AreEqual(true, valid);
        }
        [TestMethod]
        public void BImageWithInvalidMembers_WhenCheckedIfCreateValid_IsFalse(){
            //Arrange: A entry with invalid members is constructed.
            BImage image = new BImage { username=null, shapes=null, Title=null };

            //Act: the image is checked to be create valid.
            bool valid = image.CreateValid();

            //Assert: the image is not create valid.
            Assert.AreEqual(false, valid);
        }
        [TestMethod]
        public void BImageWithValidMembers_WhenCheckedIfUpdateValid_IsTrue(){
            //Arrange: A entry with valid members is constructed.
            BImage image = new BImage();
            image.Format();

            //Act: the image is checked to be update valid.
            bool valid = image.UpdateValid();

            //Assert: the image is update valid.
            Assert.AreEqual(true, valid);
        }
        [TestMethod]
        public void BImageWithInvalidMembers_WhenCheckedIfUpdateValid_IsFalse(){
            //Arrange: A entry with invalid members is constructed.
            BImage image = new BImage { 
                username = "123456789123456789123456789123456789",shapes = null,Title = null
            };

            //Act: the image is checked to be update valid.
            bool valid = image.UpdateValid();

            //Assert: the image is update valid.
            Assert.IsFalse(valid);
        }
        [TestMethod]
        public void BImage_WhenCheckedIfDeleteValid_IsTrue(){
            //Arrange: A entry is constructed.
            BImage image = new BImage();

            //Act: the image is checked to be delete valid.
            bool valid = image.DeleteValid();

            //Assert: the image is delete valid.
            Assert.AreEqual(true, valid);
        }
        [TestMethod]
        public void BImage_WhenCheckedForEquivilance_IsAlwaysFalse(){
            //Arrange: A entry with valid members is constructed.
            BImage image = new BImage();

            //Act: the image is checked to be equivilant to itself.
            bool equals = false;

            //Assert: the image is not equivilant to itself.
            Assert.AreEqual(false, equals);
        }
    }
}
