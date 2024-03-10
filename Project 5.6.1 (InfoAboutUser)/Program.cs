class Programm
{
    static void Main(string[] args)
    {
        (string Name, string LastName, int Age, string[] NamesPet, string[] FavColors) User;

        ////////////////////////////////////////////////////////////////////////////////
        
        Console.Write("Введите ваше имя: ");
        User.Name = Console.ReadLine();
        
        ////////////////////////////////////////////////////////////////////////////////
        
        Console.Write("Укажите вашу фамилию: ");
        User.LastName = Console.ReadLine();
        
        ////////////////////////////////////////////////////////////////////////////////
        
        Console.Write("Укажите ваш возраст полных лет: ");
        User.Age = int.Parse(Console.ReadLine());

        if (User.Age <= 0)
        {
            Console.Write("Вам не может быть 0 лет и во времени не путешествуете. Введите возраст больше 0: ");
            User.Age = int.Parse(Console.ReadLine());
        }
        
        ////////////////////////////////////////////////////////////////////////////////
        
        User.NamesPet = new string[0];
        Console.Write("У вас есть питомцы? Ваш ответ: ");
        string HavePet = Console.ReadLine();
        int CountPet;

        while (true)
        {
            if (HavePet.ToLower() == "да")
            {
                Console.Write("Сколько у вас питомцев? (Введите количество) ");
                if (int.TryParse(Console.ReadLine(), out CountPet))
                {
                    User.NamesPet = AddNickNamePet(CountPet);
                }
                    
                break;
            }
            else if (HavePet.ToLower() == "нет")
            {
                CountPet = 0;
                break;
            }
            else
            {
                Console.Write("Некоректнный ввод, попробуйте еще: ");
                HavePet = Console.ReadLine();
                continue;
            }
        }

        ////////////////////////////////////////////////////////////////////////////////
        
        User.FavColors = new string[0];
        Console.Write("У вас есть любимые цвета?\t");
        string HaveColors = Console.ReadLine();
        int CountColors;

        while (true)
        {
            if (HaveColors.ToLower() == "да")
            {
                Console.WriteLine("Сколько у вас любимых цветов?\t");
                CountColors = int.Parse(Console.ReadLine());
                User.FavColors = AddFavoriteColors(CountColors);
                break;
            }
            else if (HaveColors.ToLower() == "нет")
            {
                Console.Write("Вы уверены?\t");
                HaveColors = Console.ReadLine();

                if (HaveColors.ToLower() == "да")
                {
                    CountColors = 0;
                    break;
                }
                else if (HaveColors.ToLower() == "нет")
                {
                    Console.Write("Тогда введите количество любимых цветов: ");
                    CountColors = int.Parse(Console.ReadLine());
                    User.FavColors = AddFavoriteColors(CountColors);
                    break;
                }
            }
            else 
            {
                Console.Write("некорректный ввод, попробуйте еще\t");
                HaveColors = Console.ReadLine();
                continue;
            }
        }

        ////////////////////////////////////////////////////////////////////////////////
        
        Console.WriteLine("\n{0} {1}, {2}.", User.Name, User.LastName, User.Age);

        Console.Write("Клички ваших питомцев: ");
        foreach (string item1 in User.NamesPet)
        {
            Console.Write(item1 + ", ");
        }

        Console.Write("\nВаши любимые цвета: ");
        foreach (string item2 in User.FavColors)
        {
            Console.Write(item2 + ", ");
        }
        Console.ReadKey();
    }

    ////////////////////////////////////////////////////////////////////////////////
    static string[] AddNickNamePet(int LotName)
    {
        string[] NamePet = new string[LotName];
        for (int i = 0; i < LotName; i++) 
        {
            Console.Write("Введите кличку {0}-го питомца: ", i + 1);
            NamePet[i] = Console.ReadLine();
        }
        return NamePet;
    }

    ////////////////////////////////////////////////////////////////////////////////
    static string[] AddFavoriteColors(int AddCountColors)
    {
        string[] FavoriteColors = new string[AddCountColors];
        for (int i = 0; i < AddCountColors; i++)
        {
            Console.Write("Введите {0}-й любимый цвет: ", i + 1);
            FavoriteColors[i] = Console.ReadLine();
        }
        return FavoriteColors;
    }

}