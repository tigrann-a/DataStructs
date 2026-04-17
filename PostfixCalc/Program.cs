// 5 6 7 * + 1 -

using MyStackLibrary;

string[] input = new string[] { "5", "6", "7", "*", "+", "1", "-" };
MyStack<int> values = new MyStack<int>();

foreach (string token in input)
{
    int value = 0;
    // եթե ոկենը ամբողջ թիվ է, ապա այն ավելացվում է stack-ում, հակառակ դեպքում՝ այն պետք է լինի օպերատոր, որի դեպքում stack- ից հանվում են երկու արժեքներ, կատարվում է համապատասխան գործողությունը և արդյունքը դրվում stack- ում:
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

int answer = values.Pop();

Console.WriteLine(answer);


