using System;
using DrawingLib.Base;
using DrawingLib.Data.Repositories;
using Repository.Data;
using Repository.Factory;
using Repository.Helpers;
namespace DrawingLib.Factory{
    public class SqlSRepositoryFactory : IRepositoryFactory{
        public IDataRepository<T> Construct<T>(params object[] args) where T : IDataUnit {
            if (Polymorphism.IsInHierachy(typeof(T), typeof(Image))){
                return (IDataRepository<T>)Activator.CreateInstance(typeof(SqlSImageRepository), args);
            }
            else if (Polymorphism.IsInHierachy(typeof(T), typeof(Shape))){
                return (IDataRepository<T>)Activator.CreateInstance(typeof(SqlSShapeRepository), args);
            }
            return null;
        }
    }
}
