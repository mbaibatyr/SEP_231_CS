namespace MyLib2
{
    public interface ITest
    {
        void Print();
    }
    public class MyClass2
    {
        public MyClass2(){}
        public MyClass2(string name) 
        { 
            Name = name;
        }
        public string Name { get; set; }
        public string Description { get; set; }

        public string Hello(string name)
        {
            return "Hello " + name;
        }

    }
}