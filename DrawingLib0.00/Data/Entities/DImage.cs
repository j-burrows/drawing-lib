/*-- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- ---
 |  Filename:   DImage.cs
 |  Purpose:    Defines the data access logic for an image.
*/// --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- ---
using System.Data;
using DrawingLib.Business;
using DrawingLib.Factory;
using Repository.Data;
using Repository.Helpers;
namespace DrawingLib.Data.Entities{
    public class DImage : BImage, IDataUnit{
        public int key {
            get { return Image_ID; }
            set { Image_ID = value; }
        }

        public string dataError { get; set; }

        public void InitFromRow(DataRow parsing) {
            Image_ID = parsing["Image_ID"].ToInt();
            Title = parsing["Title"].ToStr();
            username = parsing["username"].ToStr();

            shapes = RepositoryFactory.Instance.Construct<DShape>(Image_ID);
        }

        public override bool Equivilant(Repository.Business.IBusinessUnit comparing){
            return this.MatchingKeyAndType<DImage>(comparing);
        }

        public void Scrub() {
            Title = Title.Scrub();
            username = username.Scrub();
        }
    }
}
