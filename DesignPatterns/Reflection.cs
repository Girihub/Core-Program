//----------------------------------------------------
// <copyright file="Reflection.cs" company="Bridgelabz">
// Company copyright tag.
// </copyright>
//----------------------------------------------------

namespace DesignPatterns
{
    using System;

    /// <summary>
    /// Reflection class
    /// </summary>
    public class Reflection
    {
        /// <summary>
        /// ReflectionTest as a function
        /// </summary>
        public static void ReflectionTest()
        {            
            int integer = 32;
            ////Check the type of input for reflection
            Type type = integer.GetType();
            Console.WriteLine(type);
        }
    }
}
