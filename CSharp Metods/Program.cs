
//void ShowText()
//{
//    Console.WriteLine("Welcome PB101");
//}

//ShowText();

//void Sum()
//{
//    int a = 5;
//    int b = 10;
//    int sum = a + b;
//    Console.WriteLine(sum);
//}



//int SumOFNumbers()
//{
//    int a=5; 
//    int b=10;
//    int sum = a + b;
//    return sum;
//}
//Console.WriteLine(SumOFNumbers());

//int SumOFNumbers()
//{
//    int a = 5;
//    int b = 10;
//    int sum = a + b;
//    return sum;
//}

//int result = SumOFNumbers();
//Console.WriteLine(result);


//string SumOFNumbers()
//{
//    int a = 5;
//    int b = 10;
//    int sum = a + b;
//    return "salam";
//}

//var result = SumOFNumbers();

//Console.WriteLine(result);


//string SumOfNumbers()
//{
//    int a = 5;
//    int b = 10;
//    int sum = a + b;
//    string res=$"Sum of numbers is - {sum}";
//    return res;
//}

//var result = SumOFNumbers();

//Console.WriteLine(result);

//void SumOfEvenNumbers()
//{
//    int[] elems = { 1, 2, 3, 4, 56 };

//    int sum = 0;

//    foreach (var item in elems)
//    {
//        if (item%2 == 0)
//        {
//            sum += item;
//        }
//    }
//    Console.WriteLine(sum);
//}

//SumOfEvenNumbers();

//}

//void ShowText(string text)
//{
//    Console.WriteLine(text);
//}
//bool IsMarried = true;
//if (IsMarried)
//{
//    string text1 = "Salam";
//    ShowText(text1);

//}
//else
//{
//    ShowText("Azerbaycan");
//}


//void Sum(int num1,int num2)
//{
//    int sum = num1 + num2;
//    Console.WriteLine(sum);

//}
//Sum(100, 200);



//void SumOfEvenNumbers(int[] elems)
//{
//    int sum = 0;

//    foreach (var item in elems)
//    {
//        if (item % 2 == 0)
//        {
//            sum += item;
//        }
//    }
//    Console.WriteLine(sum);
//}
//int[] nums = { 1, 2, 3, 4 };

//SumOfEvenNumbers(nums);

//int[] nums2 = { 1, 2, 3, 40, 70 };
//SumOfEvenNumbers(nums2);



//void SumOfEvenNumbers(int[] elems,int number)
//{
//    int sum = 0;

//    foreach (var item in elems)
//    {
//        if (item % 2 == 0)
//        {
//            sum += item;
//        }
//    }
//    int result= sum+ number;    
//    Console.WriteLine(sum);
//}

//int[] nums = { 1, 2, 3, 4 };
//SumOfEvenNumbers(nums, 5);




//int SumOfEvenNumbers(int[] elems,int number)
//{
//    int sum = 0;

//    foreach (var item in elems)
//    {
//        if (item % 2 == 0)
//        {
//            sum += item;
//        }
//    }
//    int result= sum+ number;    
//    return result;
//}

//int[] nums = { 1, 2, 3, 4 };

//Console.WriteLine(SumOfEvenNumbers(nums, 5));

//int[] elenms = { 5, 6, 7, 8, 9 };

//var result=SumOfEvenNumbers(elenms, 5);

//Console.WriteLine(result);



//string name = "Hacker";

//Console.WriteLine(name);


//Console.WriteLine("Add your name :");

//string name = Console.ReadLine();


//Console.WriteLine("Add your surname :");

//string surname = Console.ReadLine();

//Console.WriteLine(name+"-" + surname);


//int a = 5;

//Console.WriteLine(a.GetType());

//Console.WriteLine("Add first number");
//int num1=int.Parse(Console.ReadLine());

//Console.WriteLine("Add second number");
//int num2=int.Parse(Console.ReadLine());

//int result = num1 + num2;

//Console.WriteLine(result);


//int[] GetDatas(int num,params int[] nums)
//{
//    return nums;
//}

//var result = GetDatas(1,2,3,4,5,6);

//foreach (var item in result)
//{
//    Console.WriteLine(item);
//}


//int[] GetDatas(int num1,int num2, params int[] nums)
//{
//    return nums;
//}

//var result = GetDatas(1, 2, 3, 4, 5, 6);

//foreach (var item in result)
//{
//    Console.WriteLine(item);
//}


//int SumOfDatas(int num1, int num2, params int[] nums)
//{
//    int sumNumbers = num1 + num2;

//    int sumOfArrayItems = 0;

//    foreach (var item in nums)
//    {
//        sumOfArrayItems += item;
//    }
//    int result = sumNumbers + sumOfArrayItems;

//    return result;
//}

//var result = SumOfDatas(1, 2, 3, 4, 5, 6);

//Console.WriteLine(result);



//string GetNames(string name = "XXX")
//{
//    return name;
//}
//Name: string name = Console.ReadLine();

//if (name == "")
//{
//    Console.WriteLine(GetNames());
//    goto Name;
//}
//else
//{
//    Console.WriteLine(GetNames(name));
//}


//string login (string username, string password)
//{
//    if (username == "Cavid123" || password == "cavid123_")
//    {
//        return "Login succesful";
//    }
//    else
//    {
//        return "Username or password is wrong";
//    }
//}

//Console.WriteLine("Username: ");
//string username = Console.ReadLine();

//Console.WriteLine("Password: ");
//string password = Console.ReadLine();

//string result = login(username, password);

//Console.WriteLine(result);




//string login(string username, string password)
//{
//    string message;
//    if (username == "Cavid123" || password == "cavid123_")
//    {
//        message = "Login succesful";
//    }
//    else
//    {
//        message = "Username or password is wrong";
//    }
//    return message;
//}

//Console.WriteLine("Username: ");
//Uername: string username = Console.ReadLine();

//Console.WriteLine("Password: ");
//string password = Console.ReadLine();
//if (username ==""|| password == "")
//{
//    Console.WriteLine("Input cannot be empty,add username again");
//    goto Uername;
//}
//string result = login(username, password);

//Console.WriteLine(result);





//string login(string username, string password)
//{
//    string message;
//    if (username == "Cavid123" || password == "cavid123_")
//    {
//        message = "Login succesful";
//    }
//    else
//    {
//        message = "Username or password is wrong";
//    }
//    return message;
//}

//Inputs: Console.WriteLine("Username: ");
//string username = Console.ReadLine();

//Console.WriteLine("Password: ");
//string password = Console.ReadLine();
//if (username == "" || password == "")
//{
//    Console.WriteLine("Input cannot be empty,add username again");
//    goto Inputs;
//}
//string result = login(username, password);

//Console.WriteLine(result);



//string login(string username, string password)
//{
//    string message;
//    if (username == "Cavid123" || password == "cavid123_")
//    {
//        message = "Login succesful";
//    }
//    else
//    {
//        message = "Username or password is wrong";
//    }
//    return message;
//}

//Inputs: Console.WriteLine("Username: ");
//string username = Console.ReadLine();

//Console.WriteLine("Password: ");
//string password = Console.ReadLine();

//if (!IsValid(username,password))
//{
//    Console.WriteLine("Input cannot be empty,add username again");
//    goto Inputs;
//}
//string result = login(username, password);

//Console.WriteLine(result);


//bool IsValid(string username,string password)
//{
//    if (username == "" || password == "")
//    {
//        return false;
//    }
//    return true;
//}











