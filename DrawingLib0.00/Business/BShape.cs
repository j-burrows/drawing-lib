/*-- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- ---
 |  Filename:   BShape.cs
 |  Purpose:    Defines the business logic for a shape.
*/// --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- ---
using DrawingLib.Presentation;
using Repository.Business;
using Repository.Business.Protocols;
namespace DrawingLib.Business{
    public class BShape : PShape, IBusinessUnit{
        public readonly ProtocolStack Shape_ID_Rules = ProtocolStack.ForKey("Shape_ID");
        public readonly ProtocolStack Image_ID_Rules = ProtocolStack.ForKey("Image_ID");
        public readonly ProtocolStack Json_Rules = ProtocolStack.WithPremise(
            new Premise { maxLength = 4096, nullable = false}, "Json");

        public virtual bool CreateValid() {
            bool isValid = true;
            isValid = Shape_ID_Rules.Create.passes(Shape_ID) && isValid;
            isValid = Image_ID_Rules.Create.passes(Image_ID) && isValid;
            isValid = Json_Rules.Create.passes(Json) && isValid;
            return isValid;
        }

        public virtual bool UpdateValid(){
            bool isValid = true;
            isValid = Shape_ID_Rules.Update.passes(Shape_ID) && isValid;
            isValid = Image_ID_Rules.Update.passes(Image_ID) && isValid;
            isValid = Json_Rules.Update.passes(Json) && isValid;
            return isValid;
        }

        public virtual bool DeleteValid() {
            return true;
        }

        public virtual bool Equivilant(IBusinessUnit comparing) {
            return false;
        }
    }
}
