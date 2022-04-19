using CrudWF.Database;
using CrudWF.Interface;

namespace CrudWF.Services
{
    public class UnityOfWork : IUnityOfWork
    {
        private readonly DataContext _dataContext;

        public UnityOfWork(DataContext context)
        {
            _dataContext = context;
        }

        public bool Commit()
        {
            var sucess = _dataContext.SaveChanges() > 1;
            return sucess;
        }

        public void Rollback()
        {

        }
    }
}
