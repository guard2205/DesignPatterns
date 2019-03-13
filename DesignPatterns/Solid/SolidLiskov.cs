using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Solid
{
    /// <summary>
    /// Liskov substitution principle ; Objects should be repleceable with instance of their subtypes 
    /// without altering the correctness of the program, otherwise you may be using the wrong abstraction
    /// </summary>
    public class SolidLiskov
    {
    }
    public class Rectangle
    {
        public virtual int Width { get; set; }
        public virtual int Height { get; set; }

        public Rectangle()
        { }

        public Rectangle(int width, int height)
        {
            Width = width;
            Height = height;
        }
        public override string ToString()
        {
            return $"{nameof(Width)}: {Width}, {nameof(Height)}: {Height}";
        }
    } 
    public class Square : Rectangle
    {
        public override /* new */ int Width // "new", instead of overide, explicitly hides a member that is inherited from a base class.
        {
            set { base.Width = base.Height = value; }
        }
        public override /* new */ int Height
        {
            set { base.Width = base.Height = value; }
        }
    }
}
