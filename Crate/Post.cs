namespace Crate
{
    internal class Post: BathroomStall
    {
        private bool _zeroSight;


        public bool ZeroSight
        {
            get { return _zeroSight; }
            set
            {
                _zeroSight = value;

                if (_material == "Phenolic")
                {
                    _thickness = 0.875;
                } else if(_material == "Phenolic" && ZeroSight == true)
                {
                    _thickness = 1.0;
                }
                else
                {
                    _thickness = 1.25;
                }

            }
        }
    }
}