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

                if (_material == "phenolic")
                {
                    _thickness = 1;
                }
                else
                {
                    _thickness = 1.25;
                }

            }
        }
    }
}