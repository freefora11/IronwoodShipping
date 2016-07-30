using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Crate
{
    class Program
    {
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
            int panelDoorheight = 0;
            int postHeight = 0;
            int urinalHeight = 0;
            string material = "";
            bool zeroSight;
            string doorType;
            int doors;
            int panels;
            int posts;
            int urinals;

            Console.WriteLine("Height of Panels/Doors: ");
            panelDoorheight = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Height of Post: ");
            postHeight = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("height of U/s: ");
            urinalHeight = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("What material is it: ");
            material = Console.ReadLine();
            Console.WriteLine("Is it zero sight line?: ");
            zeroSight = Convert.ToBoolean(Console.ReadLine());
            Console.WriteLine("Type of door: " );
            doorType = Console.ReadLine();
            Console.WriteLine("How many doors?: ");
            doors = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("how many panels?: ");
            panels = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("how many post?: ");
            posts = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("how many urinals?: ");
            urinals = Convert.ToInt32(Console.ReadLine());

            Job job = new Job(doors, posts, panels, urinals);

            job.setHeightPieces(panelDoorheight);
            job.setHeightPost(postHeight);
            job.setHeightUrinal(urinalHeight);
            job.setMaterial(material);
            job.setZeroSight(zeroSight);
            job.ChangeTypeDoor(doorType);

            for(int i = 0; i < doors; i++)
            {
                Console.WriteLine("Door #{0} width: ",i+1);
                job.setWidthDoor(i, Convert.ToDouble(Console.ReadLine()));
            }

            for (int i = 0; i < panels; i++)
            {
                Console.WriteLine("Panel #{0} width: ", i + 1);
                job.setWidthPanel(i, Convert.ToDouble(Console.ReadLine()));
            }

            for (int i = 0; i < posts; i++)
            {
                Console.WriteLine("Post #{0} width: ", i + 1);
                job.setWidthPost(i, Convert.ToDouble(Console.ReadLine()));
            }

            for (int i = 0; i < urinals; i++)
            {
                Console.WriteLine("Urinal #{0} width: ", i + 1);
                job.setWidthUrinal(i, Convert.ToDouble(Console.ReadLine()));
            }

            job.CrateHeight();


        }
    }
}
