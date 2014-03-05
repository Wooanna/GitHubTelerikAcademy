using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPGSM
{
    class Display
    {

        private int colors = 16000;
        private static int heigth = 7;
        private static int width = 5;

        //constructor
        public Display(int colors)
        {
            this.colors = colors;

        }

        //properties
        public int Colors
        {
            get { return this.colors; }
        }

        public int Height
        {
            get { return heigth; }
        }

        public int Width
        {
            get { return width; }
        }


        public override string ToString()
        {
            StringBuilder displayInfo = new StringBuilder();
            displayInfo.Append("-------- ");
            displayInfo.Append("\nDisplay: ");
            displayInfo.Append("\n-------- ");
            displayInfo.Append("\nColors: ");
            displayInfo.Append(this.Colors);
            displayInfo.Append("\nHeight: ");
            displayInfo.Append(this.Height);
            displayInfo.Append("\nWidth: ");
            displayInfo.Append(this.Width);
            displayInfo.Append(Environment.NewLine);
            return displayInfo.ToString();
        }

    }
}
