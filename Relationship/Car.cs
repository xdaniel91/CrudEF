using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Relationship
{
    public class Car
    {
        [Key()]
        public long Id { get; set; }
        [ForeignKey("Model")]
        public long ModelId { get; set; }
        public virtual Model Model { get; set; }
        public string Name { get; set; }
        public int Year { get; set; }


        public void Save()
        {
            var db = new BaseContext();
            db.Cars.Add(this);
            db.SaveChanges();
        }

        public List<Car> GetAll()
        {
            var db = new BaseContext();
            return db.Cars.ToList();
        }
    }
}
