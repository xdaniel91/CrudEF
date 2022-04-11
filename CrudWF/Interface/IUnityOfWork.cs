using CrudWF.Database;

namespace CrudWF.Interface
{
    public interface IUnityOfWork
    {
        void Commit();

        void Rollback();
    }
}
