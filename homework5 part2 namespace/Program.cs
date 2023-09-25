/*9.Разработайте приложение «7 чудес света», где каждое 
чудо будет представлено отдельным классом. Создайте дополнительный класс, содержащий точку входа.
Распределите приложение по файлам проекта и с помощью пространства имён обеспечьте возможность 
взаимодействия классов.*/


//using WorldWonders;
//using WorldWonders.pyramid;
//using WorldWonders.Temple;
//using WorldWonders.Zeus;

//PyramidOfGiza.ShowInfo();
//TempleOfArtemis.ShowInfo();
//ZeusStatue.ShowInfo();


/*10.Разработать приложение, в котором бы сравнивалось 
население трёх столиц из разных стран. Причём страна бы обозначалась пространством имён, а город — 
классом в данном пространстве.*/


if (Azerbaijan.Baku.population < Japan.Tokyo.population)
{
    Console.WriteLine("Population of Tokyo is bigger than Baku");
}
else
{
    Console.WriteLine("Population of Tokyo is not bigger than Baku");
}

if (Azerbaijan.Baku.population < Scotland.Edinburgh.population)
{
    Console.WriteLine("Population of Edinburgh is bigger than Baku");
}
else
{
    Console.WriteLine("Population of Edinburgh is not bigger than Baku");
}

if (Japan.Tokyo.population > Scotland.Edinburgh.population)
{
    Console.WriteLine("Population of Tokyo is bigger than Edinburgh");
}
else
{
    Console.WriteLine("Population of Tokyo is not bigger than Edinburgh");
}



namespace Azerbaijan
{
    static class Baku
    {
        static public int population = 2303000; 
    }
}

namespace Japan
{
    static class Tokyo
    {
        static public int population = 14043239;
    }

}

namespace Scotland
{
    static class Edinburgh
    {
        static public int population = 527620;
    }
}
