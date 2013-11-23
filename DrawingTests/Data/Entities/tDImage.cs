using DrawingLib.Data.Entities;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace DrawingLibUnitTests.Data.Entities{
    [TestClass]
    public class tDImage : DImage{
        [TestMethod]
        public void DImageWithHtmlTitle_WhenScrubbed_BecomesSafe(){
            string malicious = "<div>Hello, world!</div>";
            DImage image = new DImage { Title = malicious };
            image.Scrub();
            Assert.AreNotEqual(image.Title, malicious);
        }
        
        [TestMethod]
        public void DImageWithHtmlUsername_WhenScrubbed_BecomesSafe(){
            string malicious = "<div>Hello, world!</div>";
            DImage image = new DImage { username = malicious };
            image.Scrub();
            Assert.AreNotEqual(image.username, malicious);
        }

        [TestMethod]
        public void DImageWithSqlTitle_WhenScrubbed_BecomesSafe(){
            string malicious = "<div>Hello, world!</div>');DROP TABLE dbo.Users;--";
            DImage image = new DImage { Title = malicious };
            image.Scrub();
            Assert.AreNotEqual(image.Title, malicious);
        }

        [TestMethod]
        public void DImageWithSqlUsername_WhenScrubbed_BecomesSafe(){
            string malicious = "<div>Hello, world!</div>');DROP TABLE dbo.Users;--";
            DImage image = new DImage { username = malicious };
            image.Scrub();
            Assert.AreNotEqual(image.username, malicious);
        }

        [TestMethod]
        public void DImageWithHtmlAndSqlTitle_WhenScrubbed_BecomesSafe(){
            string malicious = "attribute');DROP TABLE dbo.Users;--";
            DImage image = new DImage { Title = malicious };
            image.Scrub();
            Assert.AreNotEqual(image.Title, malicious);
        }

        [TestMethod]
        public void DImageWithHtmlAndSqlUsername_WhenScrubbed_BecomesSafe(){
            string malicious = "attribute');DROP TABLE dbo.Users;--";
            DImage image = new DImage { username = malicious };
            image.Scrub();
            Assert.AreNotEqual(image.username, malicious);
        }

        [TestMethod]
        public void DImage_WhenComparedAgainstDImageWithSameKey_IsEquivilant(){
            int key = 1;
            DImage first = new DImage { key = key };
            DImage second = new DImage { key = key };
            Assert.IsTrue(first.Equivilant(second));
        }

        [TestMethod]
        public void DImage_WhenAskedForKey_ReturnsCountryID(){
            DImage image = new DImage { Image_ID = -1 };
            int key = image.key;
            Assert.AreEqual(key, image.Image_ID);
        }
    }
}
