using DrawingLib.Base;
using Repository.Presentation;
namespace DrawingLib.Presentation{
    public class PShape : Shape, IPresentationUnit{
        public virtual void Format() { 
            if(Json == null){
                Json = string.Empty;
            }
        }
    }
}
