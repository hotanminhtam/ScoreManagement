using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScoreManagement.ClassManagement
{
     public class LogicClass
    {
        public LOP[] GetLOPs()
        {
            var db = new ScoreManagementEntities();
            return db.LOPs.ToArray();
        }

        public void CreateClass(int malop, string tenlop)
        {
            var newClass = new LOP();
            newClass.MALOP = malop;
            newClass.TENLOP = tenlop;

            var db = new ScoreManagementEntities();
            db.LOPs.Add(newClass);
            db.SaveChanges();
        }
        public void UpdateClass(int id, int malop, string tenlop)
        {
            var db = new ScoreManagementEntities();
            var oldClass = db.LOPs.Find(id);

            oldClass.MALOP = malop;
            oldClass.TENLOP = tenlop;
            db.Entry(oldClass).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
        }
        public void DeleteClass(int id)
        {
            var db = new ScoreManagementEntities();
            var @class = db.LOPs.Find(id);

            db.LOPs.Remove(@class);
            db.SaveChanges();
        }
        public LOP GetLOP(int id)
        {
            var db = new ScoreManagementEntities();
            return db.LOPs.Find(id);
        }
    }
}
