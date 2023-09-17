using SmallWorld.src.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmallWorld.src.Model.Interactuable
{
    //TODO: Importante hacer que una entidad utilize un item. Un item lo usas o lo dejas, debe haber un crud de items, puede tocar un item negativo, que sea malo. El item puede sumar ataque, vida, etc. Patron strategy para agregar otro objeto que determina a que se lo da.
    public class Item : IInteractable
    {
        //podria haber un item que te agregue valores por este turno, permanentemente o por un ataque
        //un item se agarra y se activa. requiere energía. no se va a saber que hace cada item.
        //item implementa un reino, es decir no todos los items pueden ser usados por todos los reinos. Esto falta implementar
        
        private static int lastId = 0;
        public int Id { get; private set; }

        IEffectStrategy effectStrategy;

        //properties
        internal IEffectStrategy EffectStrategy { get => effectStrategy; set => effectStrategy = value; }
        public string EffectName 
        { 
            get 
            {
                string name = "";
                if (effectStrategy != null) name = effectStrategy.ToString();
                return name;
            } 
        }

        public Item(IEffectStrategy effectStrategy)
        {
            lastId++;
            Id = lastId;
            EffectStrategy = effectStrategy;
        }

        public Item() { }

        public void ExecuteEffectStrategy(Entity entity)
        {
            EffectStrategy.Effect(entity);
        }

        public override string ToString()
        {
            return EffectName;
        }
    }
}
