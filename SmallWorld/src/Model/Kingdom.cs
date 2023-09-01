using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmallWorld.src.Model
{
    internal class Kingdom
    {
        private int id;
        private static int lastId = 0;
        private string name;
        private bool deleted;

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public bool Deleted { get => deleted; set => deleted = value; }

        public Kingdom(string name)
        {
            Id = ++lastId;
            Name = name;
        }
    }
}
