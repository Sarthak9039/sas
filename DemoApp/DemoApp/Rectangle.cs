using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoApp
{
    class Rectangle
    {
        #region Fields & bProperties
       private int length, width;

        public int Length
        {
            get { return length; }//read
            set { length = value; }//assignmenth
        }
        public int Width
        {
            get { return width; }//read
            set { width = value; }//assignmenth
        }

        #endregion

        #region Methods
        public int GetArea()
        {
            return length * width;
        }
        #endregion

        #region Constructor
        public Rectangle()
        {
            Length = 1;
            Width = 1;
        }

        public Rectangle( int length,int width)
        {
            this.Length = length;
            this.Width = width;
        }

        public override string ToString()
        {
            //unformatted string
            // return "Length = " + length + "Width = " + width;
            //formatted string
            // return string.Format("Length={0} ,width={1}", length,width);
            //string interpolation
            return string.Format($"len={length} width={width}");

        }
        #endregion

    }
}
