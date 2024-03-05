
//using Sealed___Struct___Nullable___Enum.Helpers;
//using Sealed___Struct___Nullable___Enum.Services;

//string email = "fatime@gmail.com";

//Console.WriteLine(email.CheckStr('@'));

//if (email.CheckStr('@'))
//{
//    Console.WriteLine("yes");

//}
//else
//{
//    Console.WriteLine("No");
//}

//string pass = "udchkehkc";

//Console.WriteLine(pass.CheckPasswordLength());

//string str = "salam3";

//tring str = "5";

//Console.WriteLine(str.CheckTextWithRegex(@"\d"));

//Console.WriteLine(str.CheckTextWithRegex(@"[a-z]"));

//int[] nums = { 1, 3, 5, 6 };

//Console.WriteLine(nums.MultiplyArrayItems());


//Console.WriteLine("Add number 1");
//string num1 = Console.ReadLine();

//Console.WriteLine("Choose one operation : +, -, /, * ");
//string operation = Console.ReadLine();

//Console.WriteLine("Add number 2");
//string num2 = Console.ReadLine();

//CalcullatorService service = new();

//string response = service.Calculation(Convert.ToDouble(num1) , operation,Convert.ToDouble(num2));

//Console.WriteLine(response);






// Sealed-Struct-Nullable-Enum . Dersin PraktikasI .



using Sealed___Struct___Nullable___Enum;

//Book book = new Book();
//book.Name = "dawawe";

//Console.WriteLine(book.Name);

////int num = 5;

//Class1 class1 = new Class1();

//class1.MyProperty = 100;

//Console.WriteLine(class1.MyProperty);



//string name = null;

//int? num = null;

//Console.WriteLine(book.Id);

//if (book.Id == null)
//{
//    Console.WriteLine("Book id notfound");

//}


//Book book1 = new()
//{
//    Id = 1,
//    Name = "Isgendername"
//};



//Book book2 = new()
//{
//    Id = 2,
//    Name = "Xosrov ve Shirin"
//};


//Book[] books = { book1, book2 };


//void GetBookById(int? id)
//{
//    Console.WriteLine(id==null);

//}

////GetBookById(null);



//void GetBookById(Book[] books ,int? id)
//{
//    if(id == null)
//    { 
//        Console.WriteLine("Your id is null");
//        return;
//    }

//    Book result = books.FirstOrDefault(m => m.Id == id);

//}

//GetBookById(books);




//Book book1 = new()
//{
//    Id = 1,
//    Name = "Isgendername"
//};



//Book book2 = new()
//{
//    Id = 2,
//    Name = "Xosrov ve Shirin"
//};

//Console.WriteLine("Book:" + book2.Name + "  Author:" + book2.Author?.Name);

//Book[] books = { book1, book2 };



//void GetLevel(string level)
//{
//    switch (level)
//    {
//        case nameof(Level.Low):
//            Console.WriteLine("Low");
//            break;
//        case nameof (Level.Medium):
//            Console.WriteLine("Medium");
//            break;
//        case nameof( Level.High):
//            Console.WriteLine("High");
//        break;
//        default:
//            Console.WriteLine("Telefonu yerine qoyun Elmir bey");
//            break;

//    }

//}
//GetLevel("Asdsa");