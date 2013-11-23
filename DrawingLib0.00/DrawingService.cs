/*-- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- ---
 |  Filename:   DrawingService.cs
 |  Purpose:    Defines the main services provided by the library.
*/// --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- ---
using System.Collections.Generic;
using System.ServiceModel;
using DrawingLib.Base;
using DrawingLib.Data.Entities;
using DrawingLib.Factory;
using DrawingLib.Presentation;
using System.Linq;
using Repository.Data;
namespace DrawingLib{
    public class DrawingService : IDrawingService{
        public IEnumerable<PImage> Image_GetByUser(string username) {
            return RepositoryFactory.Instance.Construct<DImage>(username);
        }

        public IEnumerable<PShape> Shape_GetByImage(int Image_ID){
            return RepositoryFactory.Instance.Construct<DShape>(Image_ID);
        }
        
        public IEnumerable<PImage> Image_Create(DImage creating, string username){
            IDataRepository<DImage> images = 
                RepositoryFactory.Instance.Construct<DImage>(username);
            images.Create(creating);

            return images;
        }

        public IEnumerable<PImage> Image_Update(DImage updating, string username){
            IDataRepository<DImage> images = 
                RepositoryFactory.Instance.Construct<DImage>(username);
            images.Update(updating);

            return images;
        }

        public IEnumerable<PImage> Image_Delete(DImage deleting, string username){
            IDataRepository<DImage> images = 
                RepositoryFactory.Instance.Construct<DImage>(username);
            images.Delete(deleting);

            return images;
        }

        public IEnumerable<PShape> Shape_Create(DShape creating, string username) {
            IDataRepository<DImage> images = 
                RepositoryFactory.Instance.Construct<DImage>(username);
            IDataRepository<DShape> shapes;
            //Finds first repository belonging to given user and image, then creates shape
            if ((shapes = images.FirstOrDefault(x => 
                    x.Image_ID == creating.Image_ID 
                    && x.username == username).shapes as IDataRepository<DShape>) 
                != null){
                shapes.Create(creating);
            }

            return shapes;
        }

        public IEnumerable<PShape> Shape_Update(DShape updating, string username) {
            IDataRepository<DImage> images = 
                RepositoryFactory.Instance.Construct<DImage>(username);
            IDataRepository<DShape> shapes;
            if ((shapes = images.FirstOrDefault(x => 
                    x.Image_ID == updating.Image_ID
                    && x.username == username).shapes as IDataRepository<DShape>) 
                != null){
                shapes.Update(updating);
            }

            return shapes;
        }
        
        public IEnumerable<PShape> Shape_Delete(DShape deleting, string username){
            IDataRepository<DImage> images = 
                RepositoryFactory.Instance.Construct<DImage>(username);
            IDataRepository<DShape> shapes;
            //Shape is deleted from the shape repository belonging given to user and image.
            if ((shapes = images.FirstOrDefault(x => 
                    x.Image_ID == deleting.Image_ID 
                    && x.username == username).shapes as IDataRepository<DShape>) 
                != null){
                shapes.Delete(deleting);
            }

            return shapes;
        }
    }
}
