

//Student student = new();
//student.Print();
//student.setMarks("Design", 3);
//student.setMarks("Design", 2);
//student.setMarks("Design", 8);
//student.setMarks("Design", 6);
//student.setMarks("Design", 4);
//Console.WriteLine(student.AverageMark("Design"));


/*1.Описать структуру Article, содержащую следующие 
поля: код товара; название товара; цену товара.
2. Описать структуру Client содержащую поля: код
клиента; ФИО; адрес; телефон; количество заказов 
осуществленных клиентом; общая сумма заказов 
клиента.
3. Описать структуру RequestItem содержащую поля: 
товар; количество единиц товара.
4. Описать структуру Request содержащую поля: код
заказа; клиент; дата заказа; перечень заказанных товаров;
сумма заказа(реализовать вычисляемым свойством).
5.Описать перечисление ArticleType определяющее 
типы товаров, и  добавить соответствующее поле 
в структуру Article из задания №1.
6. Описать перечисление ClientType определяющее 
важность клиента, и добавить соответствующее поле 
в структуру Client из задания №2.
7. Описать перечисление PayType определяющее форму 
оплаты клиентом заказа, и добавить соответствующее 
поле в структуру Request из задания №4.*/

struct Article
{
    public int ArticleId { get; set; }
    public string Name { get; set; }
    public int Price { get; set; }
    private int _type;

    public int Type
    {
        get { return _type; }
        set
        {
            if (value > 0 && value <= 6)
            {
                _type = value;
            }
        }
    }





}

struct Client
{
    public int ClientId { get; set; }
    public string FullName { get; set; }
    public string Address { get; set; }
    public long Phone { get; set; }
    public int OrdersQuantity { get; set; }
    public int OrdersSumm { get; set; }
    private int _clientType;

    public int ClientType
    {
        get { return _clientType; }
        set
        {
            if (value > 0 && value <= 4)
            {
                _clientType = value;
            }
        }
    }
}

struct RequestItem
{
    public Article Item { get; set; }
    public int ItemsQuantity { get; set; }
}

struct Request
{
    public int OrdersId { get; set; }
    public Client Client { get; set; }
    public DateTime Date { get; set; }
    private RequestItem[] _items;
    private int _ordersPrice;

    public int OrdersPrice
    {
        get { return _ordersPrice; }
        set 
        {
            _ordersPrice = 0;
            foreach (var item in _items)
            {
                _ordersPrice += item.Item.Price;
            }
        }
    }

    private int _howPayType;

    public int HowPayType
    {
        get { return _howPayType; }
        set
        {
            if (value > 0 && value <= 3)
            {
                _howPayType = value;
            }
        }
    }




}

enum ArticleType
{
    Clothes = 1,
    Home,
    Indoor,
    Outdoor,
    Chemical,
    ForKids
}

enum ClientType
{
    ExtraImprotant = 1,
    VeryImportant,
    Important,
    Normal
}

enum PayType
{
    CreditCard = 1,
    DebitCard,
    Cash
}

