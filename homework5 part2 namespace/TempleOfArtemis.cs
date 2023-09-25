
namespace WorldWonders
{

    namespace Temple
    {
        static class TempleOfArtemis
        {
            private static string _name = "Temple of Artemis at Ephesus";
            private static string _country = "Greece";
            private static string _city = "Ephesus";


            public static void ShowInfo()
            {
                Console.WriteLine($"{_name}, {_country}, {_city}");
            }
        }
    }

}