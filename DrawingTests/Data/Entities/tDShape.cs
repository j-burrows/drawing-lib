using DrawingLib.Data.Entities;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace DrawingLibUnitTests.Data.Entities{
    [TestClass]
    public class tDShape : DShape{
        [TestMethod]
        public void DShapeWithHtmlAndSqlMembers_WhenScrubbed_RemainsTheSame(){
            string malicious = "attribute');DROP TABLE dbo.Users;--";
            DShape shape = new DShape { Json = malicious };
            shape.Scrub();
            Assert.AreEqual(shape.Json, malicious);
        }

        [TestMethod]
        public void DShape_WhenComparedAgainstDShapeWithSameKey_IsEquivilant(){
            int key = 1;
            DShape first = new DShape { key = key };
            DShape second = new DShape { key = key };
            Assert.IsTrue(first.Equivilant(second));
        }

        [TestMethod]
        public void DShape_WhenAskedForKey_ReturnsCountryID(){
            DShape shape = new DShape { Shape_ID = -1 };
            int key = shape.key;
            Assert.AreEqual(key, shape.Shape_ID);
        }
    }
}
