using CrudWF.Database;
using CrudWF.Interface;
using Microsoft.EntityFrameworkCore;

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
           var X = _dataContext.SaveChanges();
            Console.WriteLine("...");

        }

        public void Rollback()
        {
        }


    }
}
