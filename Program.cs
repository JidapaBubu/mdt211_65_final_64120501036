class Program
{
    static void Main(string[] args){
        Stack<int> s = new Stack<int>();
        while(true){
            char text = char.Parse(Console.ReadLine());
            if (text == '(')
            {
                s.Push(text);
            }
            else if (text == ')')
            {
                s.Push(text);
            }
            else {break;}
        }
    }
}

 