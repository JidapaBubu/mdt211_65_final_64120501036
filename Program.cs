class Program
{
    static void Main(string[] args)
    {
        Stack<int> satcking = new Stack<int>();
        whlie(true){
            char text = char.Pharse(Console.ReadLine());
            if (text == '(')
            {
                satcking.Push(2);
            }
            else if (text == ')')
            {
                satcking.Push(1);
            }
        }
    }
}