using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScoreManagement.StudentManagement
{
    public class Logic
    {
        public SVIEN[] GetSVIENs()
        {
            var db = new ScoreManagementEntities();
            return db.SVIENs.ToArray();
        }
        public SVIEN GetSVIEN(int id)
        {
            var db = new ScoreManagementEntities();
            return db.SVIENs.Find(id);
        }
        public void CreateStudents(int manganh, string masv, string tensv, DateTime ngaysinh,
                                    bool gioitinh, string sdt, string email, int cmnd, string quequan, string diachi)
        {
            var student = new SVIEN();
            student.MANGANH = manganh;
            student.MASV = masv;
            student.TENSV = tensv;
            student.NGAYSINH = ngaysinh;
            student.GIOITINH = gioitinh;
            student.SDT = sdt;
            student.EMAIL = email;
            student.CMND = cmnd;
            student.QUEQUAN = quequan;
            student.DIACHI = diachi;

            var db = new ScoreManagementEntities();
            db.SVIENs.Add(student);
            db.SaveChanges();
        }
        public void UpdateStudent(int id, int manganh, string masv, string tensv, DateTime ngaysinh,
                                    bool gioitinh, string sdt, string email, int cmnd, string quequan, string diachi)
        {
            var db = new ScoreManagementEntities();
            var student = db.SVIENs.Find(id);

            student.MANGANH = manganh;
            student.MASV = masv;
            student.TENSV = tensv;
            student.NGAYSINH = ngaysinh;
            student.GIOITINH = gioitinh;
            student.SDT = sdt;
            student.EMAIL = email;
            student.CMND = cmnd;
            student.QUEQUAN = quequan;
            student.DIACHI = diachi;

            db.Entry(student).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
        }
        public void DeleteStudent(int id)
        {
            var db = new ScoreManagementEntities();
            var student = db.SVIENs.Find(id);

            db.SVIENs.Remove(student);
            db.SaveChanges();
        }

        public SVIEN[] GetStudentsOfFaculty(string faculty)
        {
            var db = new ScoreManagementEntities();
            var id = GetFaculty(faculty);
            return db.SVIENs.Where(item => item.MANGANH.Equals(id)).ToArray();
        }

        private int GetFaculty(string tenNghanh)
        {
            var db = new ScoreManagementEntities();
            return db.NGANHs.Where(item => item.TENNGANH.Equals(tenNghanh)).FirstOrDefault().MANGANH;
        }
    }
}
