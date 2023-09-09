using SmallWorld.src.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmallWorld.src.Model.Interactuable
{
    //TODO: Importante hacer que una entidad utilize un item. Un item lo usas o lo dejas, debe haber un crud de items, puede tocar un item negativo, que sea malo. El item puede sumar ataque, vida, etc. Patron strategy para agregar otro objeto que determina a que se lo da.
    internal class Item : IInteractable
    {
        private int points; //Puntos que la entidad se puede sumar o restar en caso de ser un item negativo.
        //podria haber un item que te agregue valores por este turno, permanentemente o por un ataque
        //un item se agarra y se activa. requiere energía. no se va a saber que hace cada item.
        //item implementa un reino, es decir no todos los items pueden ser usados por todos los reinos.
        public int Points { get => points; set => points = value; }
        public Item(int points)
        {
            Points = points;
        }
        public Item()
        {

        }
    }
}
