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
/*เรียงความแสดงความอาลัยเนื่องจากพอเข้าใจแต่ไม่สามารถเขียนออกมาได้
หากใช้ stack ช่วยจะทำให้สามารถนับค่าได้อย่างรวดเร็ว
เนื่องจากรูปแบบการทำงานคือแสดงข้อมูลรวมทุกอย่างหลังกรอกตัวสุดท้ายที่ต้องการได้
ซึ่งทำการใช้ loop เข้ามาช่วยในการทำงาน หรือใช้ bool เขามาช่วยเพราะมีรูปแบบโครงสร้าง
เหมือน true falsh*/

 