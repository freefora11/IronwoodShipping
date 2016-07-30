using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crate
{
    class Job
    {
        private Door[] _doors;
        private Post[] _posts;
        private Panel[] _panels;
        private Urinal[] _urinals;

        

        public Job(int doors,int posts, int panels, int urinals)
        {
            //prevents exception when there are no panels/post/doors/urinals
            if (doors == 0)
            {
                _doors = new Door[1];
            }
            else
            {
                _doors = new Door[doors];
            }

            if (posts == 0)
            {
                _posts = new Post[1];
            }
            else
            {
                _posts = new Post[posts];
            }

            if (panels == 0)
            {
                _panels = new Panel[1];
            }
            else
            {
                _panels = new Panel[panels];
            }

            if (urinals == 0)
            {
                _urinals = new Urinal[1];
            }
            else
            {
                _urinals = new Urinal[urinals];
            }
            initalizeObjects();
        }

        public void ChangeTypeDoor(string type)
        {
            foreach(Door i in _doors)
            {
                i.TypeOfDoor = type;
            }
        }

        //set for zerosightline
        public void setZeroSight(bool zero)
        {
            if (zero)
            {
                foreach(Door i in _doors)
                {
                    i.ZeroSight = true;
                }
                foreach(Post i in _posts)
                {
                    i.ZeroSight = true;
                }
            }
            else
            {
                foreach (Door i in _doors)
                {
                    i.ZeroSight = false;
                }
                foreach (Post i in _posts)
                {
                    i.ZeroSight = false;
                }
            }
        }

        //get height of post
        public double getHeightPost()
        {
            if(_posts[0] != null)
            {
                return _posts[0].Height;
            }
            else
            {
                return 0;
            }
        }

        //get height of door
        public double getHeightDoor()
        {
            if (_doors[0] != null)
            {
                return _doors[0].Height;
            }
            else
            {
                return 0;
            }
        }

        //sets the height of all doors and panels
        public void setHeightPieces(double height)
        {
            //change all door heights
            foreach(Door i in _doors)
            {
                i.Height = height;
            }
            //change all panel heights
            foreach (Panel i in _panels)
            {
                i.Height = height;
            }

        }

        public void setHeightPost(double height)
        {
            //change height of all post
            foreach(Post i in _posts)
            {
                i.Height = height;
            }
        }

        public void setHeightUrinal(double height)
        {
            //change height for all urinals
            foreach(Urinal i in _urinals)
            {
                i.Height = height;
            }
        }

        public void setWidthDoor(int index, double width)
        {
            _doors[index].Width = width;
        }

        public void setWidthPanel(int index, double width)
        {
            _panels[index].Width = width;
        }

        public void setWidthPost(int index, double width)
        {
            _posts[index].Width = width;
        }

        public void setWidthUrinal(int index, double width)
        {
            _urinals[index].Width = width;
        }

        public void setMaterial(string material)
        {
            if(material == "Phenolic" || material == "Laminate" || material == "Vener")
            {

                foreach(Panel i in _panels)
                {
                    i.Material = material;
                    i.ChangeThickness();
                }
                foreach(Urinal i in _urinals)
                {
                    i.Material = material;
                    i.ChangeThickness();
                    
                }
                foreach(Door i in _doors)
                {
                    i.Material = material;
                }
                foreach(Urinal i in _urinals)
                {
                    i.Material = material;
                }
            }
            else
            {
                Console.WriteLine("Not a valid material.");
            }
        }

        //used for debugging
        public void Display()
        {
            foreach(Door i in _doors)
            {
                Console.WriteLine("Door #{0} Height: " +i.Height,i );
                Console.WriteLine("Door #{0} Width: " + i.Width,i);
                Console.WriteLine("Door #{0} Material: " + i.Material,i);
                Console.WriteLine("Door #{0} Thickness: " + i.Thickness,i);
                Console.WriteLine("Door #{0} ZeroSight: " + i.ZeroSight,i);
                Console.WriteLine("Door #{0} DoorType: " + i.TypeOfDoor,i);
            }

            foreach (Panel i in _panels)
            {
                Console.WriteLine("Panel #{0} Height: " + i.Height, i);
                Console.WriteLine("Panel #{0} Width: " + i.Width, i);
                Console.WriteLine("Panel #{0} Material: " + i.Material, i);
                Console.WriteLine("Panel #{0} Thickness: " + i.Thickness, i);
            }

            foreach (Post i in _posts)
            {
                Console.WriteLine("Post #{0} Height: " + i.Height, i);
                Console.WriteLine("Post #{0} Width: " + i.Width, i);
                Console.WriteLine("Post #{0} Material: " + i.Material, i);
                Console.WriteLine("Post #{0} Thickness: " + i.Thickness, i);
                Console.WriteLine("Post #{0} ZeroSight: " + i.ZeroSight, i);
            }

            foreach (Urinal i in _urinals)
            {
                Console.WriteLine("Urinal #{0} Height: " + i.Height, i);
                Console.WriteLine("Urinal #{0} Width: " + i.Width, i);
                Console.WriteLine("Urinal #{0} Material: " + i.Material, i);
                Console.WriteLine("Urinal #{0} Thickness: " + i.Thickness, i);
            }
        }

        private void initalizeObjects()
        {
            for(int i = 0; i < _doors.Length; i++)
            {
                _doors[i] = new Door();
            }
            for (int i = 0; i < _panels.Length; i++)
            {
                _panels[i] = new Panel();
            }
            for (int i = 0; i < _posts.Length; i++)
            {
                _posts[i] = new Post();
            }
            for (int i = 0; i < _urinals.Length; i++)
            {
                _urinals[i] = new Urinal();
            }
        }

        public int ArrangePost()
        {
            int row = 0;
            double rowWidth = 0;

            //prevents exception when there are no post
            if (_posts[0].Width == 0)
                return 0;
            
            //sets row width
                if (_posts[0].ZeroSight)
                {
                    rowWidth = 60;
                }
                else
                {
                    rowWidth = 59;
                }
            

            //sort Post array by width, greatest to lease
            List <int> postWidthHolder = SortPostWidth();

            // this adds up the post till it reaches row width or no more post
            // if it reaches row width, it makes a new row and repeats till no more post
            while(postWidthHolder.Count != 0)
            {
                int widthHolder = 0;
                List<int> deletePostList = new List<int>();

                for (int i = 0;i < postWidthHolder.Count; i++)
                {
                    if(widthHolder <= rowWidth && (widthHolder + postWidthHolder[i]) <= rowWidth)
                    {
                        widthHolder += postWidthHolder[i];
                        deletePostList.Add(i);
                    }
                    
                }
                int j = 0;
                for (int h = 0; h < deletePostList.Count; h++)
                {
                    if(h == 0)
                    {
                        postWidthHolder.RemoveAt(deletePostList[h]);
                    }else
                    {
                        postWidthHolder.RemoveAt(deletePostList[h]- j);
                    }
                    j++;
                }
                row += 1;
            }

            //return the amount of rows from pylasters.
            return row;
        }
        //sorts the array of post by width greatest to least
        private List <int> SortPostWidth()
        {
            List <int> holder = new List<int>();

            for(int i = 0; i < _posts.Length; i++)
            {
                holder.Add(Convert.ToInt32(_posts[i].Width));
            }
            holder.Sort();
            holder.Reverse();
            return holder;
        }

        public int ArrangePanels()
        {
            //checks if there are panels
            if (_panels[0].Width == 0)
                return 0;

            //sorts the panels by width from greatest to least
            List<int> holder = new List<int>();

            for (int i = 0; i < _panels.Length; i++)
            {
                holder.Add(Convert.ToInt32(_panels[i].Width));
            }
            holder.Sort();
            holder.Reverse();

            //return amount of rows, future implement showing which panels should go down.
            return holder.Count;
            
        }

        public int ArrangeDoors()
        {
            List<int> holder = new List<int>();
            int row = 0;

            //checks if there are doors or not
            if (_doors[0].Width == 0)
                return 0;

            for (int i = 0; i < _doors.Length; i++)
            {
                holder.Add(Convert.ToInt32(_doors[i].Width));
            }
            holder.Sort();
            holder.Reverse();

            while(holder.Count != 0)
            {
                holder.RemoveAt(0);
                if(holder.Count >= 1)
                    holder.RemoveAt(holder.Count - 1);
                row++;
            }
            return row;
        }

        public int ArrangeUrinals()
        {
            int row = 0;
            double rowWidth = 0;

            //checks if there are urinals, if not, return 0
            if (_urinals[0].Width == 0)
                return 0;

            if (_posts[0].ZeroSight)
            {
                rowWidth = 60;
            }
            else
            {
                rowWidth = 59;
            }

            //sort urinal array by width, greatest to lease, same algorithm as ArrangePost()
            List<int> urinalWidthHolder = SortUrinalWidth();
            while (urinalWidthHolder.Count != 0)
            {
                int widthHolder = 0;
                List<int> deleteUrinalList = new List<int>();

                for (int i = 0; i < urinalWidthHolder.Count; i++)
                {
                    if (widthHolder <= rowWidth && (widthHolder + urinalWidthHolder[i]) <= rowWidth)
                    {
                        widthHolder += urinalWidthHolder[i];
                        deleteUrinalList.Add(i);
                    }

                }
                int j = 0;
                for (int h = 0; h < deleteUrinalList.Count; h++)
                {
                    if (h == 0)
                    {
                        urinalWidthHolder.RemoveAt(deleteUrinalList[h]);
                    }
                    else
                    {
                        urinalWidthHolder.RemoveAt(deleteUrinalList[h] - j);
                    }
                    j++;
                }
                row += 1;
            }

            //return the amount of rows from urinal.
            return row;
        }

        public List<int> SortUrinalWidth()
        {
            List<int> holder = new List<int>();

            for (int i = 0; i < _urinals.Length; i++)
            {
                holder.Add(Convert.ToInt32(_urinals[i].Width));
            }
            holder.Sort();
            holder.Reverse();
            return holder;
        }

        public double CrateHeight()
        {
            //variables
            double foam = 0;
            double height = 0;
            double rowPost = 0;
            double rowPanel = 0;
            double rowDoor = 0;
            double rowUrinal = 0;
            const double EXTRA = 0.5;
            const double FOAM_THICKNESS = 0.125;
            double rowArrangePost = 0;
            double rowArrangePanels = 0;
            double rowArrangeDoors = 0;
            double rowArrangeUrinals = 0;

            //get amount of rows from each method
            if (_panels[0] != null)
                rowArrangePanels = ArrangePanels();
            if (_posts[0] != null)
                rowArrangePost = ArrangePost();
            if (_doors[0] != null)
                rowArrangeDoors = ArrangeDoors();
            if (_urinals[0] != null)
                rowArrangeUrinals = ArrangeUrinals();

            //get the thickness
            if(_posts != null || _posts[0] != null)
            {
                rowPost = rowArrangePost * _posts[0].Thickness;
            }
            if(_panels != null || _panels[0] != null)
            {
                rowPanel = rowArrangePanels * _panels[0].Thickness;
            }
            if(_doors != null || _doors[0] != null)
            {
                rowDoor = rowArrangeDoors * _doors[0].Thickness;
            }
            if(_urinals != null || _urinals[0] != null)
            {
                rowUrinal = rowArrangeUrinals * _urinals[0].Thickness;
            }
            //add up thickness
            foam = (rowArrangeUrinals + rowArrangePost + rowArrangePanels + rowArrangeDoors) * FOAM_THICKNESS;
            height = EXTRA + rowDoor + rowPanel + rowPost + rowUrinal + foam;
            /*used for debugging
            Console.WriteLine("rowpost: " + rowPost);
            Console.WriteLine("rowpanel: " + rowPanel);
            Console.WriteLine("rowdoor: " + rowDoor);
            Console.WriteLine("rowUrinal: " + rowUrinal);
            Console.WriteLine("height: " + height);
            */
            return height;
        }


    }
}
