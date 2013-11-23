/*-- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- ---
 |  Filename:   BImage.cs
 |  Purpose:    Defines the business logic for an image.
*/// --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- ---
using DrawingLib.Presentation;
using Repository.Business;
using Repository.Business.Protocols;
namespace DrawingLib.Business{
    public class BImage : PImage, IBusinessUnit{
        public readonly ProtocolStack Image_ID_Rules = ProtocolStack.ForKey("Image_ID");
        public readonly ProtocolStack Title_Rules = ProtocolStack.WithPremise(
            new Premise { nullable = false, maxLength = 16}, "Title");
        public readonly ProtocolStack username_Rules = ProtocolStack.ForUsername();

        public virtual bool CreateValid() {
            bool isValid = true;
            isValid = Image_ID_Rules.Create.passes(Image_ID) && isValid;
            isValid = Title_Rules.Create.passes(Title) && isValid;
            isValid = username_Rules.Create.passes(username) && isValid;
            return isValid;
        }

        public virtual bool UpdateValid() {
            bool isValid = true;
            isValid = Image_ID_Rules.Update.passes(Image_ID) && isValid;
            isValid = Title_Rules.Update.passes(Title) && isValid;
            isValid = username_Rules.Update.passes(username) && isValid;
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
