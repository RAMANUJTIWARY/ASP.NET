// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler
// //Properties are the special type of class members that provides a flexible mechanism to read, write, or compute the value of a private field.
// Read and Write Properties: When property contains both get and set methods.
// Read-Only Properties: When property contains only get method.
// Write Only Properties: When property contains only set method.
// Auto Implemented Properties: When there is no additional logic in the property accessors and it introduce in C# 3.0.
using System;
class student{
        int _StdId;
        string _Name;
        string _FName;
        public int StdId{
            set{ 
                this._StdId=value;
            }
            get{
                return this._StdId;
            }
        }
        
}
class Program{
    public static void Main(string[] args)
    {
        student s1=new student();
        s1.StdId=20;
        Console.WriteLine(s1.StdId);
    }
}
