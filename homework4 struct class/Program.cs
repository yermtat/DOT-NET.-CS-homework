//// task 1
//WebSite site = new WebSite();
//site.ShowInfo();
//Console.WriteLine();

//WebSite site2 = new WebSite("Facebook", "facebook.com", "Social network", "31.13.72.36");
//site2.ShowInfo();
//site2.setIP("Unknown");
//Console.WriteLine(site2.getIP());



////task2
//Journal journal = new Journal("мир фантастики", 2003, "Мир фантастики о фэнтези и фантастике во всех проявлениях.",
//    74959845383, "textby@mirf.ru");

//journal.ShowInfo();



/*Задание 3
Создайте класс «Магазин». Необходимо хранить в 
полях класса: название магазина, адрес, описание профиля магазина, контактный телефон, контактный e-mail. 
Реализуйте методы класса для ввода данных, вывода 
данных, реализуйте доступ к отдельным полям через 
методы класса.*/

class Shop
{
    string name;
    string adress;
    string summary;
    private long phoneNumber;
    private string email;

    public Shop(string name, string adress, string summary, long phoneNumber, string email)
    {
        this.name = name;
        this.adress = adress;
        this.summary = summary;
        this.phoneNumber = phoneNumber;
        this.email = email;
    }

    public void ShowInfo()
    {
        Console.WriteLine($"Name: {name}\nAdress: {adress}\nSummary: {summary}\nPhone number: {phoneNumber}" +
            $"\nEmail: {email}");
    }

    public string getName()
    {
        return name;
    }
    public void setName(string name)
    {
        this.name = name;
    }

    public string getAdress()
    {
        return adress;
    }
    public void setAdress(string adress)
    {
        this.adress = adress;
    }

    public string getSummary()
    {
        return summary;
    }
    public void setSummary(string summary)
    {
        this.summary = summary;
    }

    public long getPhoneNumber()
    {
        return phoneNumber;
    }
    public void setPhoneNumber(long phoneNumber)
    {
        this.phoneNumber = phoneNumber;
    }

    public string getEmail()
    {
        return email;
    }
    public void setEmail(string email)
    {
        this.email = email;
    }
}


/*Задание 2
Создайте класс «Журнал». Необходимо хранить в 
полях класса: название журнала, год основания, описание журнала, контактный телефон, контактный e-mail. 
Реализуйте методы класса для ввода данных, вывода 
данных, реализуйте доступ к отдельным полям через 
методы класса.*/


class Journal
{
    private string name;
    private int foundationYear;
    private string summary;
    private long phoneNumber;
    private string email;

    public Journal(string name, int foundationYear, string summary, long phoneNumber, string email)
    {
        this.name = name;
        this.foundationYear = foundationYear;
        this.summary = summary;
        this.phoneNumber = phoneNumber;
        this.email = email;
    }

    public void ShowInfo()
    {
        Console.WriteLine($"Name: {name}\nFoundation year: {foundationYear}\nSummary: {summary}\nPhone number: {phoneNumber}" +
            $"\nEmail: {email}");
    }

    public string getName()
    {
        return name;
    }
    public void setName(string name)
    {
        this.name = name;
    }

    public int getFoundationYear()
    {
        return foundationYear;
    }
    public void setFoundationYear(int year)
    {
        foundationYear= year;
    }

    public string getSummary()
    {
        return summary;
    }
    public void setSummary(string summary)
    {
        this.summary = summary;
    }

    public long getPhoneNumber()
    {
        return phoneNumber;
    }
    public void setPhoneNumber(long phoneNumber)
    {
        this.phoneNumber = phoneNumber;
    }

    public string getEmail()
    {
        return email;
    }
    public void setEmail(string email)
    {
        this.email = email;
    }

}



/*Задание 1
Создайте класс «Веб-сайт». Необходимо хранить в 
полях класса: название сайта, путь к сайту, описание 
сайта, ip адрес сайта. Реализуйте методы класса для ввода 
данных, вывода данных, реализуйте доступ к отдельным 
полям через методы класса.*/
class WebSite
{
    private string name;
    private string adress;
    private string summary;
    private string ip;

    public WebSite()
    {
        name = "IT STEP";
        adress = "itstep.az";
        summary = "Computer academy";
        ip = "188.114.96.1";
    }
    public WebSite(string name, string adress, string summary, string ip)
    {
        this.name = name;
        this.adress = adress;
        this.summary = summary;
        this.ip = ip;
    }

    public void ShowInfo()
    {
        Console.WriteLine($"Name: {name} adress: {adress}\nSummary: {summary}\nIP adress: {ip}");  
    }

    public string getName()
    {
        return name;
    }
    public void setName(string name)
    {
        this.name = name;
    }

    public string getAdress()
    {
        return adress;
    }
    public void setAdress(string adress)
    {
        this.adress = adress;
    }

    public string getSummary()
    {
        return summary;
    }
    public void setSummary(string summary)
    {
        this.summary = summary;
    }

    public string getIP()
    {
        return ip;
    }
    public void setIP(string ip)
    {
        this.ip = ip;
    }

}