using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_InheritanceSecondTask
{
    class Base
    {
        public int Id { get; set; }
        public int ReferanceNumber { get; set; }
        public int DocumentNumber { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Gender { get; set; }
        public DateTime DateOfStartWorking { get; set; }
        public DateTime DateOfEndWorking { get; set; }
        public string RegUser { get; set; }
        public DateTime RegDate { get; set; }
        public DateTime? EditUser { get; set; }
        public DateTime? EditDate { get; set; }
        public bool Deleted { get; set; }
    }
}
