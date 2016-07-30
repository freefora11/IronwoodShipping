

namespace Crate
{
    internal class Door : BathroomStall
    {

        private string _typeOfDoor;
        private bool _zeroSight;

        public override double Width
        {
            get{ return _width; }
            set
            {

                if (_zeroSight)
                {
                    _width = value + 0.75;
                }
                else
                {
                    _width = value - 0.5;
                }
            }

        }

        //set/get the type of door
        public string TypeOfDoor
        {
            get { return _typeOfDoor; }
            set
            {   if(value == "Standard" || value == "Louver" || value == "Molding")
                {
                   _typeOfDoor = value;
                    if (_material == "Phenolic")
                    {
                        _thickness = 0.875;
                    }
                    else if (_material == "Phenolic" && ZeroSight == true)
                    {
                        _thickness = 1;
                    }
                    else if(_material == "Phenolic" && _typeOfDoor == "Molding")
                    {
                        _thickness = 1.875;
                    }
                    else if(_material == "Phenolic" && _typeOfDoor == "Molding" && ZeroSight == true)
                    {
                        _thickness = 2.0;
                    }
                    else if (_typeOfDoor == "Louver" && ZeroSight == true)
                    {
                        _thickness = 1.25;
                    }
                    else if(_typeOfDoor == "Louver")
                    {
                        _thickness = 1.25;
                    }
                    else if(_typeOfDoor == "Molding" && ZeroSight == true)
                    {
                        _thickness = 2.25;
                    }
                    else if(_typeOfDoor == "Molding")
                    {
                        _thickness = 1.875;
                    }
                    else
                    {
                        _thickness = 0.875;
                    }
                }
                else
                {
                    throw new System.Exception("NotValidDoorType");
                }
                

            }
        }
        //sets/gets if the door is zerosightline
        public bool ZeroSight
        {
            get { return _zeroSight; }
            set
            {  _zeroSight = value;

                if(_material == "Phenolic")
                {
                    _thickness = 1;
                }
                else if (value || _typeOfDoor == "Louver")
                {
                    _thickness = 1.25;
                }
                else if(ZeroSight && _typeOfDoor == "Molding")
                {
                    _thickness = 2.25;
                }
                else
                {
                    _thickness = 0.875;
                }
               
            }
        }

    }
}