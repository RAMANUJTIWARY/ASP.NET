using System;
namespace basic1

{
    internal class Program
    {
        static void Main(string[] args)
        {
            //operator :-Operators are used to perform operations on variables and values.
            // types of operator :-
            //i. unary operator :-it will work using single operand  ex- increment and decrement

            //+ : Unary plus
            //- : Unary minus
            //++ : Increment
            //-- : Decrement
            //! : Logical NOT
            //~ : Bitwise NOT

            //post increment
            int a = 5, b;
            b = a++;
            Console.WriteLine("a={0} and b={1}", a, b);

            //preincrement
            int l = 10, m;
            m = ++l;
            Console.WriteLine("l={0} and m={1}", l, m);//l=11,m=11;


            //binary operator:-
            /*
             * 
             * 1.arithmetic operator:- +,-,*,/
               2.Relational Operators:

                == : Equal to
                != : Not equal to
                > : Greater than
                < : Less than
                >= : Greater than or equal to
                <= : Less than or equal to
            3.Logical Operators:

                && : Logical AND
                || : Logical OR
                ! : Logical NOT
            4.Bitwise Operators:

                & : Bitwise AND
                | : Bitwise OR
                ^ : Bitwise XOR
                ~ : Bitwise NOT
                << : Left shift
                >> : Right shift
            5.Assignment Operators:

                = : Assignment
                += : Addition assignment
                -= : Subtraction assignment
                *= : Multiplication assignment
                /= : Division assignment
                %= : Modulus assignment
                &= : Bitwise AND assignment
                |= : Bitwise OR assignment
                ^= : Bitwise XOR assignment
                <<= : Left shift assignment
                >>= : Right shift assignment
            6.Conditional Operator:

                ?: : Ternary conditional (if-else)
            7.Null-Coalescing Operators:

                ?? : Returns the left-hand operand if it is not null; otherwise, it returns the right-hand operand.
                ??= : Assigns the right-hand operand to the left-hand operand only if the left-hand operand is null.

            8.Member Access and Pointer Operators:

                . : Member access
                -> : Pointer to member access
                [] : Array or indexer access
                * : Pointer dereference
                & : Address-of operator
            9.Type Operators:

                is : Checks if an object is compatible with a given type
                as : Attempts to cast an object to a specific type
                sizeof : Returns the size of a type
                typeof : Returns the Type object for a type
                checked and unchecked : Used to control overflow-checking context
            
            10.Lambda and Delegate Operators:

                    => : Lambda operator
            */
        }
    } 
}
