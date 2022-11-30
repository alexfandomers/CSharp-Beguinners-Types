namespace Types
{
     public class Person
     {
        public int Age;
     }
    public class Program
    {
        static void Main(string[] args)
        {  
            //value type
           var a = 10;
           var b = a;
           b++;
           Console.WriteLine("{0} {1}", a, b); 

           //reference type
           var array1 = new int[3] {1,2,3};
           var array2 = array1;
           array2[0] = 0;
           Console.WriteLine("{0} {1}", array1[0], array2[0]);

           //another exemple//
           var number =1;
           Increment(number);
           Console.WriteLine(number);

           //value type
           var person = new Person() {Age = 20};
           MakeOld(person);

           //reference type
           Console.WriteLine(person.Age);
        }
        public static void Increment(int number)
        {
            number +=10;
        }
        public static void MakeOld(Person person)
        {
            person.Age += 10;
        }
    }
}
