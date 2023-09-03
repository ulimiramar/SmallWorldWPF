using SmallWorld.src.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmallWorld.src.Model.Reino
{
    internal class Vegetable : IKingdom
    {/*
        public int Id { get => Id; set => Id = value; }
        public string Name { get => Name; set => Name = value; }
        public bool Deleted { get => Deleted; set => Deleted = value; }*/
        public override string ToString()
        {
            return "Vegetal";
        }
    }
}
