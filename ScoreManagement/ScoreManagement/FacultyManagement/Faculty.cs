using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScoreManagement.FacultyManagement
{
    public partial class Faculty
    {
        public int ID { get; set; }
        public int MAKHOA { get; set; }
        public string TENKHOA { get; set; }

        public Faculty(KHOA khoa)
        {
            this.ID = khoa.ID;
            this.MAKHOA = khoa.MAKHOA;
            this.TENKHOA = khoa.TENKHOA;
        }
    }
}
