/*-- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- ---
 |  Filename:   Shape.cs
 |  Purpose:    Defines a shape and its members.
*/// --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- ---
namespace DrawingLib.Base{
    public class Shape{
        public virtual int Shape_ID { get; set; }
        public virtual int Image_ID { get; set; }
        public virtual string Json { get; set; }
    }
}
