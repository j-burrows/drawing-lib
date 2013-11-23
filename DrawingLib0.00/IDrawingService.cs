/*-- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- ---
 |  Filename:   DrawingService.cs
 |  Purpose:    Declares the main services provided by the library.
 |  Note:       This service is ready to be deployed as a web service at a later date.
 |  Date:       October 14th 2013
*/// --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- ---
using System.Collections.Generic;
using System.ServiceModel;
using DrawingLib.Base;
using DrawingLib.Data.Entities;
using DrawingLib.Presentation;
namespace DrawingLib{
    [ServiceContract]
    public interface IDrawingService{
        /*-- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- ---
         |  Function:   Image_GetByUser
         |  Purpose:    Retrieves all images belonging to a given user.
         |  Param:      username            The belonger of the targeted images.
         |  Return:     IEnumerable<PImage> Collection of all belonging images.
        */// --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- ---
        [OperationContract]
        IEnumerable<PImage> Image_GetByUser(string username);
        /*-- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- ---
         |  Function:   Shape_GetByImage
         |  Purpose:    Retrieves all shapes belonging to a given shape.
         |  Param:      Image_ID            The owning image of the shapes.
         |  Return:     IEnumerable<PShape> Collection of all belonging shapes.
        */// --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- ---
        [OperationContract]
        IEnumerable<PShape> Shape_GetByImage(int Image_ID);

        /*-- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- ---
         |  Function:   Shape_Create
         |  Purpose:    Creates a shape and returns the resulting collection.
         |  Param:      creating            The shape being added to the database.
         |              username            The owner of the shape.
         |  Return:     IEnumerable<PShape> Resulting collection of shapes.
         +-- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- ---
        */
        [OperationContract]
        IEnumerable<PShape> Shape_Create(DShape creating, string username);
        /*-- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- ---
         |  Function:   Shape_Update
         |  Purpose:    Updates a shape and returns the resulting collection.
         |  Param:      updating            The shape being updated in the database.
         |              username            The owner of the shape.
         |  Return:     IEnumerable<PShape> Resulting collection of shapes.
         +-- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- ---
        */
        [OperationContract]
        IEnumerable<PShape> Shape_Update(DShape updating, string username);
        /*-- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- ---
         |  Function:   Shape_Delete
         |  Purpose:    Deletes a shape and returns the resulting collection.
         |  Param:      deleting            The shape being deleted from the database.
         |              username            The owner of the shape.
         |  Return:     IEnumerable<PShape> Resulting collection of shapes.
         +-- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- ---
        */
        [OperationContract]
        IEnumerable<PShape> Shape_Delete(DShape deleting, string username);

        /*-- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- ---
         |  Function:   Image_Create
         |  Purpose:    Creates an image and returns the resulting collection.
         |  Param:      creating            The shape being created in the database.
         |              username            The owner of the shape.
         |  Return:     IEnumerable<PShape> Resulting collection of shapes.
         +-- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- ---
        */
        [OperationContract]
        IEnumerable<PImage> Image_Create(DImage creating, string username);
        /*-- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- ---
         |  Function:   Image_Update
         |  Purpose:    Updates an image and returns the resulting collection.
         |  Param:      updating            The shape being updated in the database.
         |              username            The owner of the shape.
         |  Return:     IEnumerable<PShape> Resulting collection of shapes.
         +-- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- ---
        */
        [OperationContract]
        IEnumerable<PImage> Image_Update(DImage updating, string username);
        /*-- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- ---
         |  Function:   Image_Delete
         |  Purpose:    Deletes an image and returns the resulting collection.
         |  Param:      deleting            The shape being updated in the database.
         |              username            The owner of the shape.
         |  Return:     IEnumerable<PShape> Resulting collection of shapes.
         +-- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- ---
        */
        [OperationContract]
        IEnumerable<PImage> Image_Delete(DImage deleting, string username);
    }
}
