using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstConsoleIBMproject
{

    // Generic class Shape with a type parameter T
    internal class Shape <T>
    {
        // Private field to hold the shape's name
        private T shapeName;
        // Default constructor
        public Shape()
        {
            shapeName = default(T); // Initializes shapeName to the default value of type T
        }
        // Parameterized constructor
        public Shape(T name)
        {
            shapeName = name; // Sets shapeName to the provided name
        }
        // Property to get or set the shape's name
        public T ShapeName
        {
            get { return shapeName; } // Returns the current value of shapeName
            set { shapeName = value; } // Sets a new value for shapeName
        }
    }
}
