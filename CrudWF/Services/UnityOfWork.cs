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
        public void Commit()
        {
            _dataContext.SaveChanges();
        }

        public void Rollback()
        {
           
        }
    }
}
