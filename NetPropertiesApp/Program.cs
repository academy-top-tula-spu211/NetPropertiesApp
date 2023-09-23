using printer = System.Console;



MyData obj1 = new MyData();
obj1.SetValue(1);
printer.WriteLine(obj1.GetValue());

obj1.Name = "test";
obj1.Number = 1;
Console.WriteLine(obj1.Name, obj1.Number);
MyData.Stat = 10;

Console.WriteLine(User.GetMainId());

int? n = null;
Console.WriteLine(n.HasValue);
Console.WriteLine((n.HasValue) ? n.Value : "");

int m = n ?? 200;
Console.WriteLine(m);

var f = n > 10;


User user = new User("Bob");
user = null;

if (user is not null)
    if (user.Company != null)
        Console.WriteLine(user.Company.Title);

Console.WriteLine(user?.Company?.Title);


static class Math
{
    public static double sin(double x)
    {
        return 1.0; 
    }
}

class Company
{
    public string? Title { set; get; }
}

class User
{
    static int IdMain = 0;

    public string Name { set; get; }
    public int Id { get; }
    public Company? Company { set; get; } = new Company(); 

    static User()
    {
        IdMain = 10;
    }

    public User(string name)
    {
        Name = name;
        Id = ++IdMain;
    }

    public static int GetMainId()
    {
        return IdMain;
    }
}

class MyData
{
    public static int Stat;
    int number;
    string? name;

    public int Age { set; get; }

    //int age;

    //public int Age
    //{
    //    set
    //    {
    //        if (value > 0 && value < 120)
    //            age = value;

    //    }
    //    get { return this.age; }

    //}

    public void SetValue(int number) { this.number = number; }
    public int GetValue() { return this.number; }



    public string Name
    {
        get { return this.name; }
        set { this.name = value; }
    }


    public int Number
    {
        get { return this.number; }
        set
        {
            if(value != 0)
                this.number = value;
        }
    }
}
