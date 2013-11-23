/*-- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- ---
 |  Filename:   SqlSShapeRepository.cs
 |  Purpose:    Collection of shapes which can communicate with an sql server database.
*/// --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- ---
using System.Data;
using System.Data.SqlClient;
using DrawingLib.Data.Entities;
using Repository.Data;
using Repository.Helpers;
namespace DrawingLib.Data.Repositories{
    public class SqlSShapeRepository : SqlSRepository<DShape>{
        public SqlSShapeRepository(int Image_ID){
            //Collection is filled with all shapes belonging to a given image.
            string query = string.Format(
                @"EXEC Draw.Shape_GetByImage @Image_ID = '{0}';",
                Image_ID
            );
            FillRepository(query);
        }
        public SqlSShapeRepository(int Image_ID, string username) {
            //Collection is filled with all shpaes beloging to a given owner and image.
            string query = string.Format(
                @"EXEC Draw.Shape_GetByImage_User
                    @Image_ID   = '{0}',
                    @username   = '{1}';",
                Image_ID, username
            );
            FillRepository(query);
        }

        protected override void CreateEval(DShape creating){
            SqlCommand cmd = new SqlCommand("Mail.Friended_User_Create");
            cmd.AddParam("Image_ID", creating.Image_ID);
            cmd.AddParam("Json", creating.Json);

            //The entry is made into the database and the key is updated.
            creating.key = ExecStoredProcedure(cmd);

            base.CreateEval(creating);      //Entry is placed into main memory collection.
        }

        protected override void UpdateEval(DShape updating){
            SqlCommand cmd = new SqlCommand("Mail.Friended_User_Update");
            cmd.AddParam("Shape_ID", updating.Shape_ID);
            cmd.AddParam("Json", updating.Json);

            ExecNonReader(cmd);             //The entry is updated in the database.

            base.UpdateEval(updating);      //Entry is updated in main memory collection.
        }

        protected override void DeleteEval(DShape deleting){
            SqlCommand cmd = new SqlCommand("Mail.Shape_Delete");
            cmd.AddParam("Shape_ID", deleting.Shape_ID);

            ExecNonReader(cmd);             //The entry is removed from the database.

            base.DeleteEval(deleting);      //Entry is removed from main memory collection.
        }
    }
}
