using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScoreManagement.FacultyManagement
{
    public class Logic
    {
        public KHOA[] GetKHOAs()
        {
            var db = new ScoreManagementEntities();
            return db.KHOAs.ToArray();
        }

        public KHOA GetFaculty(int id)
        {
            var db = new ScoreManagementEntities();
            return db.KHOAs.Find(id);
        }

        public void CreateFaculty(int makhoa, string tenkhoa)
        {
            var fac = new KHOA();
            fac.MAKHOA = makhoa;
            fac.TENKHOA = tenkhoa;

            var db = new ScoreManagementEntities();
            db.KHOAs.Add(fac);
            db.SaveChanges();
        }

        public void DeleteFaculty (int id)
        {
            var db = new ScoreManagementEntities();
            var fac = db.KHOAs.Find(id);
            db.KHOAs.Remove(fac);
            db.SaveChanges();
        }

        public void EditFaculty(int id, int makhoa, string tenkhoa)
        {
            var db = new ScoreManagementEntities();
            var oldFac = db.KHOAs.Find(id);

            oldFac.MAKHOA = makhoa;
            oldFac.TENKHOA = tenkhoa;

            db.Entry(oldFac).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
        }
    }
}
