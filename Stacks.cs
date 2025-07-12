//Stack is LIFO (Last In First Out)
//Undoing stuff,backtracking algo

// | Operation | Description                                 |
// | --------- | ------------------------------------------- |
// | Push      | Add an element to the top                   |
// | Pop       | Remove the top element                      |
// | Peek      | Look at the top element without removing it |
// | Count     | Number of elements in the stack             |

//normally O(1)
//when searching 0(n)

using System.Collections.Generic;
namespace Stacks;

public class StacksMain
{
    public static string StacksExample()
    {
        //declare a stack
        Stack <string> stringtStack = new Stack<string>();
        //Last In First Out Order
        stringtStack.Push("Porsche");//at the bottom
        stringtStack.Push("Lamborghini");
        stringtStack.Push("Ferrari");//at the top
        string output = " STACK is NOT EMPTY";

        output += $"\n Number of Items in the STACK: {stringtStack.Count} ";
        output += $"\n Items: {string.Join(",", stringtStack)} ";   //prints from top of the stack to bottom ;
        output += $"\n Pop the Last One: {stringtStack.Pop()}";
        output += $"\n Top Element: {stringtStack.Peek()}";
        output += $"\n Searched For: {stringtStack.Contains("Porsche")}";

        //check  to see if the stack is empty
        if (stringtStack.Count == 0)
        {
            return "STACK is EMPTY";
        }
        return output;
      
    }
}