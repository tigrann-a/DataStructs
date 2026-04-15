// 5 6 7 * 1 -

using MyStackLibrary;
using System.Collections.Generic;

string[] input = new string[] { "5", "6", "7", "*", "1", "-" };
MyStack<int> values = new MyStack<int>();

foreach (string token in input)
{
    int value = 0;
    if (int.TryParse(token, out value))
        values.Push(value);
    else
    {
        int right = values.Pop();
        int left = values.Pop();
        

        switch (token)
        {
            case "+":
                values.Push(left + right);
                break;
            case "-":
                values.Push(left - right);
                break;
            case "*":
                values.Push(left * right);
                break;
            case "/":
                values.Push(left / right);
                break;
            default:
                throw new ArgumentException("There is unexpected operator");
        }
    }

}
