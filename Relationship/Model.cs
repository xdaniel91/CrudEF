using System.ComponentModel.DataAnnotations;

namespace Relationship
{
    public class Model
    {
        [Key()]
        public long Id { get; set; }
        public string Name { get; set; }

        public void Save()
        {
            var db = new BaseContext();
            db.Models.Add(this);
            db.SaveChanges();
        }

        public List<Model> GetAll()
        {
            var db = new BaseContext();
            
            return db.Models.ToList();
        }
    }
}
