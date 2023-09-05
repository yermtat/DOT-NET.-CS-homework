//Создать базовый класс «Устройство» и производные классы «Чайник», «Микроволновка», «Автомобиль», «Пароход».
//С помощью конструктора установить имя каждого устройства и его характеристики.
//Реализуйте для каждого из классов методы:
//■ Sound — издает звук устройства (пишем текстом в 
//консоль);
//■ Show — отображает название устройства;
//■ Desc — отображает описание устройства;


Device device = new("Origin", 454336);
Kettle kettle = new Kettle(3, "electric kettle", 3245);
Microwave microwave = new Microwave(7, 30, "LG microwave", 99999);
Auto auto = new(100, 300, "ferrari", 123456);
Steamer steamer= new Steamer(4, "Sand steamer", 2107);

Foo(device);
Foo(kettle);
Foo(microwave);
Foo(auto);
Foo(steamer);

void Foo(Device device)
{
    device.Sound();
    device.Show();
    device.Desc();
    Console.WriteLine();
}

class Device
{
    public string Name     {get; set;}
    public int SerialNumber {get; set;}

    public Device()
    {

    }

    public Device(string name, int serialNumber)
    {
        Name = name;
        SerialNumber = serialNumber;
    }

    public virtual void Sound()
    {
        Console.WriteLine("Generic beep boop");
    }

    public virtual void Show()
    {
        Console.WriteLine("Device");
    }

    public virtual void Desc() 
    {
        Console.WriteLine($"Name: {Name}\nSerial number: {SerialNumber}");
    }
}


class Kettle : Device
{
    public int capacity { get; set;}

    public Kettle()
    {

    }

    public Kettle(int capacity, string name, int serialNumber) : base(name, serialNumber)
    {
        this.capacity = capacity;
    }

    public override void Desc()
    {
        base.Desc();
        Console.WriteLine($"Capacity: {capacity} liter");
    }

    public override void Show()
    {
        Console.WriteLine("Kettle");
    }

    public override void Sound()
    {
        Console.WriteLine("Kettle's whistling");
    }
}


class Microwave : Device
{
    public int ModesNumber {get; set; }
    public int TimerLimit  { get; set; }

    public Microwave()
    {

    }

    public Microwave(int modesNumber, int timerLimit, string name, int serialNumber) : base(name, serialNumber)
    {
        ModesNumber = modesNumber;
        TimerLimit = timerLimit;
    }

    public override void Desc()
    {
        base.Desc();
        Console.WriteLine($"Number of modes: {ModesNumber}\nTimer limit: {TimerLimit} minutes");
    }

    public override void Show()
    {
        Console.WriteLine("Microwave");
    }

    public override void Sound()
    {
        base.Sound();
        Console.WriteLine("Microwave squeak");
    }
}


class Auto : Device
{
    public int Mileage    {get; set; }
    public int Horsepower {get; set; }

    public Auto()
    {

    }
    public Auto(int mileage, int horsepower, string name, int serialNumber) : base(name, serialNumber)
    {
        Mileage = mileage;
        Horsepower = horsepower;
    }

    public override void Desc()
    {
        base.Desc();
        Console.WriteLine($"Mileage: {Mileage} kilometers\nHorsepower: {Horsepower}");
    }

    public override void Show()
    {
        Console.WriteLine("Automobile");
    }  

    public override void Sound()
    {
        Console.WriteLine("Car's honk");
    }
}


class Steamer : Device
{
    public int decks { get; set; }

    public Steamer()
    {

    }
    public Steamer(int decks, string name, int serialNumber) : base(name, serialNumber) 
    {
        this.decks = decks;
    }

    public override void Sound()
    {
        Console.WriteLine("HOOOOOOOOOOOONK");
    }

    public override void Show()
    {
        Console.WriteLine("Steamer");
    }

    public override void Desc()
    {
        base.Desc();
        Console.WriteLine($"Deck's number: {decks}");
    }
}
