using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using DrawingLib;
using DrawingLib.Base;
using DrawingLib.Business;
using DrawingLib.Data.Entities;
using Repository.Business.Protocols;

namespace DrawingLibDebug
{
    class Program
    {
        static void Main(string[] args)
        {
            //Arrange: A entry with invalid members is constructed.
            BImage image = new BImage { username = null, shapes = null, Title = "123456789123456789123456789123456789" };

            //Act: the image is checked to be create valid.
            bool valid = image.CreateValid();
            image.Format();
        }
    }
}
