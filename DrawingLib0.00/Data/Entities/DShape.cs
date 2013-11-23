/*-- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- ---
 |  Filename:   DShape.cs
 |  Purpose:    Defines the data access logic for a shape.
*/// --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- ---
using System.Data;
using DrawingLib.Business;
using Repository.Data;
using Repository.Helpers;
namespace DrawingLib.Data.Entities{
    public class DShape : BShape, IDataUnit{
        public int key {
            get { return Shape_ID; }
            set { Shape_ID = value; }
        }

        public string dataError { get; set; }

        public void InitFromRow(DataRow parsing) {
            Json = parsing["Json"].ToStr();
            Shape_ID = parsing["Shape_ID"].ToInt();
            Image_ID = parsing["Image_ID"].ToInt();
        }

        public override bool Equivilant(Repository.Business.IBusinessUnit comparing){
            return this.MatchingKeyAndType<DShape>(comparing);
        }

        public void Scrub(){
            //Explicitly no scrubbing will occur as it will invalidate the Json.
        }
    }
}
