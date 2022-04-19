using CrudWF.Database;

namespace CrudWF.Interface
{
    public interface IUnityOfWork
    {
        bool Commit();

        void Rollback();
    }
}
