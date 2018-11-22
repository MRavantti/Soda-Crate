using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SodaCrate
{
    class Bottle
    {
        //variables for the constructor
        private decimal _price { get; }
        private string _name { get; }
        private string _type { get; }

        //the constructor to set value, name and type.
        public Bottle(decimal price, string name, string type)
        {
            _price = price;
            _name = name;
            _type = type;

        }

        public string GetSodaType()
        {
            return _type;
        }

        public decimal GetSodaPrice()
        {
            return _price;
        }

        public string GetSodaName()
        {
            return _name;
        }
    }
    //All the different kinds of soda with set value, type and name.
    class Bonaqua : Bottle
    {
        public Bonaqua() : base(new decimal(11.90), "Bonaqua", "Water")
        {
        }
    }

    class Loka : Bottle
    {
        public Loka() : base(new decimal(11.90), "Loka", "Water")
        {
        }
    }

    class Ramlösa : Bottle
    {
        public Ramlösa() : base(new decimal(11.90), "Ramlösa", "Water")
        {
        }
    }

    class CocaCola : Bottle
    {
        public CocaCola() : base(new decimal(14.90), "Coca-Cola", "Soda")
        {
        }
    }

    class CocaColaLight : Bottle
    {
        public CocaColaLight() : base(new decimal(14.90), "Coca-Cola Light", "Soda")
        {
        }
    }

    class CocaColaZero : Bottle
    {
        public CocaColaZero() : base(new decimal(14.90), "Coca-Cola Zero", "Soda")
        {
        }
    }

    class Fanta : Bottle
    {
        public Fanta() : base(new decimal(14.90), "Fanta", "Soda")
        {
        }
    }

    class FantaExotic : Bottle
    {
        public FantaExotic() : base(new decimal(14.90), "Fanta Exotic", "Soda")
        {
        }
    }

    class Sprite : Bottle
    {
        public Sprite() : base(new decimal(14.90), "Sprite", "Soda")
        {
        }
    }

    class Falcon : Bottle
    {
        public Falcon() : base(new decimal(14.90), "Falcon", "Beer")
        {
        }
    }

    class Heineken : Bottle
    {
        public Heineken() : base(new decimal(14.90), "Heineken", "Beer")
        {
        }
    }

    class NorrlandsGuld : Bottle
    {
        public NorrlandsGuld() : base(new decimal(14.90), "Norrlands Guld", "Beer")
        {
        }
    }

    class Tuborg : Bottle
    {
        public Tuborg() : base(new decimal(14.90), "Tuborg", "Beer")
        {
        }
    }
}