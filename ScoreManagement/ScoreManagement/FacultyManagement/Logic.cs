using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScoreManagement.FacultyManagement
{
    class Logic
    {
        public KHOA[] GetKHOAs()
        {
            var db = new ScoreManagementEntities();
            return db.KHOAs.ToArray();
        }

        public KHOA GetStudent(int makhoa)
        {
            var db = new ScoreManagementEntities();
            return db.KHOAs.Find(makhoa);
        }

        public void CreateFaculty (int makhoa, string tenkhoa)
        {
            var fac = new KHOA();
            fac.MAKHOA = makhoa;
            fac.TENKHOA = tenkhoa;

            var db = new ScoreManagementEntities();
            db.KHOAs.Add(fac);
            db.SaveChanges();
        }
    }
}
