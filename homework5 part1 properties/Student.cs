
/*8.Придумать класс, описывающий студента.Предусмотреть в нем следующие моменты: фамилия, имя,
отчество, группа, возраст, массив (зубчатый) оценок по
программированию, администрированию и дизайну.
А также добавить методы по работе с перечисленными
данными: возможность установки/получения оценки, получение среднего балла по заданному предмету,
распечатка данных о студенте.*/



class Student
{
    public string Name { get; set; }
    public string Surname { get; set; }
    public string FathersName { get; set; }
    public int Group { get; set; }
    public int Age { get; set; }
    private int[][] marks;

    private static int _desMarksCount = 0;
    private static int _admMarksCount = 0;
    private static int _progMarksCount = 0;

    public Student()
    {
        Name = "Default";
        Surname = "Default'ov";
        FathersName = "Default'ovich";
        Group = 312;
        Age = 150;

        marks = new int[3][];
        marks[0] = new int[7];
        marks[1] = new int[10];
        marks[2] = new int[8];
    }
    public Student(string name, string surname, string fathersName, int group, int age, int[][] marks)
    {
        Name = name;
        Surname = surname;
        FathersName = fathersName;
        Group = group;
        Age = age;

        marks = new int[3][];

        marks[0] = new int[7];
        marks[1] = new int[10];
        marks[2] = new int[8];
    }

    public void setMarks(string subject, int mark)
    {
        if ((int)Enum.Parse(typeof(Subject), subject) == 0 && _progMarksCount < 7)
        {
            marks[(int)Enum.Parse(typeof(Subject), subject)][_progMarksCount++] = mark;
        }
        else if ((int)Enum.Parse(typeof(Subject), subject) == 1 && _admMarksCount < 10)
        {
            marks[(int)Enum.Parse(typeof(Subject), subject)][_admMarksCount++] = mark;
        }
        else if ((int)Enum.Parse(typeof(Subject), subject) == 2 && _desMarksCount < 8)
        {
            marks[(int)Enum.Parse(typeof(Subject), subject)][_desMarksCount++] = mark;
        }
    }

    public double AverageMark(string subject)
    {
        if (Enum.IsDefined(typeof(Subject), subject)) 
        { 
            return marks[(int)Enum.Parse(typeof(Subject), subject)].Average();
        }
        return 0;
    }

    public void Print()
    {
        Console.WriteLine($"Full name: {Name} {Surname} {FathersName}\nAge: {Age}\nGroup: {Group}\n");


    }

}

enum Subject
{
    Programming = 0,
    Administrative,
    Design
};