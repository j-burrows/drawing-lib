using System.Linq;
using DrawingLib.Base;
using Repository.Presentation;
namespace DrawingLib.Presentation{
    public class PImage : Image, IPresentationUnit{
        public virtual void Format() { 
            if(shapes == null){
                shapes = Enumerable.Empty<Shape>();
            }
            if (Title == null) {
                Title = string.Empty;
            }
            if (username == null) {
                username = string.Empty;
            }
        }
    }
}
