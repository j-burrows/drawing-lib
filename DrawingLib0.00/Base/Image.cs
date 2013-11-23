/*-- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- ---
 |  Filename:   Image.cs
 |  Purpose:    Defines an image an its members.
*/// --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- ---
using System.Collections.Generic;
namespace DrawingLib.Base{
    public class Image{
        public virtual int Image_ID { get; set; }
        public virtual string Title { get; set; }
        public virtual string username { get; set; }
        public IEnumerable<Shape> shapes { get; set; }
    }
}
