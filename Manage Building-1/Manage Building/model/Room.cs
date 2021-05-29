using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manage_Building.model
{
    public class Room
    {
        public int Id { get; set; }

        public string name { get; set; }

        public int Capacity { get; set; }

        public int type { get; set; }

        public Building Building { get; set; }

    }
}
