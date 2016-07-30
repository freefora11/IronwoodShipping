using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crate
{
    class BathroomStall
    {
        protected double _height;
        protected double _width;
        protected static string _material;
        protected double _thickness;

        public BathroomStall()
        {
            _height = 0;
            _width = 0;
            _material = "";
            _thickness = 0;
        }

        public double Thickness
        {
            get { return _thickness; }
        }

        public double Height
        {
            get { return _height; }
            set { _height = value; }
        }

        public virtual double Width
        {
            get { return _width; }
            set { _width = value; }
        }

        public string Material
        {
            get { return _material; }
            set
            {
                if (value == "Phenolic" || value == "Vener" || value == "Laminate")
                {
                    _material = value;
                }
                else
                {
                    throw new System.Exception("NotValidMaterialType");
                }
            }
        }

    }
}
