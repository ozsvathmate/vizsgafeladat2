using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vizsgafeladat2.Entities
{
    public class Termek
    {
        public Guid ID { get; set; } = Guid.NewGuid();
        public string Termeknev { get; set; }
        public int Ar { get; set; }
        public int Kaphato_e;
    }
 }
