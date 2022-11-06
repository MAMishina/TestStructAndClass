namespace TestStructAndClass
{
    internal class PersonClass
    {
        public string name;
        public int age;


        public PersonClass(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public void Method(string s)
        {
            string name = s;
            name = name.ToUpper();
            Console.WriteLine(name);

            this.name = this.name.ToUpper();
            Console.WriteLine(name);
            Console.WriteLine(this.name);
        }

        public void Met1(ref int a)
        {

        }

        public void Met2(out int a)
        {
            a = 0;
        }

        public void Met3(in int a)
        {
           // a = 0;
            Console.WriteLine(a);
        }
    }
}
