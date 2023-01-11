using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm
{
    [Serializable]
    public class Figure
    {
        public Location Location { get; set; }
        public Size Size { get; set; }

        public Figure() 
        { 
            Location = new Location();
            Size = new Size(50, 30);
        }
    }
}
