namespace progam {
    class Program{

        class Person {
            public string Name {get; set;}
            public int Age {get; set;}
        }
 
 
static void Main(){
  List<Person> people = new List<Person>
        {
            new Person { Name = "Alice", Age = 25 },
            new Person { Name = "Bob", Age = 30 },
            new Person { Name = "Charlie", Age = 22 }
        };
        int [] luckyNumbers = {0,56,32,10,1,4,6};
        luckyNumbers[1] = 36;
        Console.WriteLine(luckyNumbers[1]);
}
};

 }  
