/*-- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- ---
 |  Filename:   SqlSImageRepository.cs
 |  Purpose:    Collection of images which can communicate with an sql server database.
*/// --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- ---
using System.Data;
using System.Data.SqlClient;
using DrawingLib.Data.Entities;
using Repository.Data;
using Repository.Helpers;
namespace DrawingLib.Data.Repositories{
    public class SqlSImageRepository: SqlSRepository<DImage>{
        public SqlSImageRepository(string username) {
            //The repository is filled with images belonging to a user.
            string query = string.Format(
                @"EXEC Draw.Image_GetByUser @username = '{0}';",
                username
            );
            FillRepository(query);
        }

        protected override void CreateEval(DImage creating){
            SqlCommand cmd = new SqlCommand("Draw.Image_Create");
            cmd.AddParam("Title",creating.Title);
            cmd.AddParam("username", creating.username);

            //The entry is made into the database and the key is updated.
            creating.key = ExecStoredProcedure(cmd);

            base.CreateEval(creating);      //Entry is placed in main memory collection.
        }

        protected override void UpdateEval(DImage updating){
            SqlCommand cmd = new SqlCommand("Draw.Image_Update");
            cmd.AddParam("Image_ID", updating.Image_ID);
            cmd.AddParam("Title", updating.Title);

            ExecNonReader(cmd);             //The entry is updated in the database.

            base.UpdateEval(updating);      //Entry is updated in main memory collection.
        }

        protected override void DeleteEval(DImage deleting){
            SqlCommand cmd = new SqlCommand("Draw.Image_Delete");
            cmd.AddParam("Image_ID", deleting.Image_ID);

            ExecNonReader(cmd);             //The entry is removed from the database.

            base.DeleteEval(deleting);      //Entry is removed from main memory collection.
        }
    }
}
