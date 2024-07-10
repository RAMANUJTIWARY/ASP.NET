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
                
                    int a = 10;
                    a %= 3; // a is now 1 (equivalent to a = a % 3)



                &= : Bitwise AND assignment
                    
                    int a = 10;
                    a %= 3; // a is now 1 (equivalent to a = a % 3)


                |= : Bitwise OR assignment
                ^= : Bitwise XOR assignment
                <<= : Left shift assignment

                    int a = 5; // 101 in binary
                    a <<= 1; // a is now 10 (1010 in binary, equivalent to a = a << 1)

                >>= : Right shift assignment
                    int a = 10; // 1010 in binary
                    a >>= 1; // a is now 5 (0101 in binary, equivalent to a = a >> 1)

            6.Conditional Operator:

                ?: : Ternary conditional (if-else)
            7.Null-Coalescing Operators:
                if the operand is not null, providing a concise way to check for null values before accessing properties, methods, or indexers.
                This operator helps prevent NullReferenceException errors 

                ?? : Returns the left-hand operand if it is not null; otherwise, it returns the right-hand operand.
                ??= : Assigns the right-hand operand to the left-hand operand only if the left-hand operand is null.

            8.Member Access and Pointer Operators:

                . : Member access ->  . is used to access members (fields, properties, methods, events) of a type (class, struct, enum, etc.).
                -> : Pointer to member access ->> The -> operator is used in an unsafe context to access members of a struct through a pointer. This operator is mainly used in low-level programming.
                [] : Array or indexer access  -> The [] operator is used to access elements of an array or an indexer.
                * : Pointer dereference
                & : Address-of operator
            9.Type Operators:

                is : Checks if an object is compatible with a given type
                as : Attempts to cast an object to a specific type
                sizeof : Returns the size of a type
                typeof : Returns the Type object for a type
                checked and unchecked : Used to control overflow-checking context
            
            10.Lambda and Delegate Operators:
                A delegate is a type that represents references to methods with a specific parameter list and return type. It allows methods to be passed as parameters, assigned to variables, and returned from other methods. Delegates are particularly useful for implementing event handling and callback methods.
                 => : A lambda expression is a shorthand syntax for defining anonymous methods using the => operator
                         Func<int, int, int> add = (x, y) => x + y;
                            Console.WriteLine(add(3, 4)); // Output: 7

            */
        }
    } 
}
