

namespace WorldWonders
{

    namespace Zeus
    {
        static class ZeusStatue
        {
            private static string _name = "Statue of Zeus at Olympia";
            private static string _country = "Greece";
            private static string _city = "Olympia";


            public static void ShowInfo()
            {
                Console.WriteLine($"{_name}, {_country}, {_city}");
            }
        }
    }

}