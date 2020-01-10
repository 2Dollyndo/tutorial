using System;
using System.Collections.Generic;

namespace ContosoUniversity.Models {
    public class Student {
        public int ID {
            get; set;
        }
        public string Nome{
            get; set;
        }
        public string Sobrenome{
            get; set;
        }
        public DateTime Data {
            get; set;
        }
        public string Secret {
            get; set;
        }

        public virtual ICollection<Enrollment> Enrollments {
            get; set;
        }
    }
}