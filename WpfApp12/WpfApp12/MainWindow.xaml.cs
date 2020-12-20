using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp12
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// Интерфейс++++++++++++++++++++++++++++++++++++++++++++++++++++
    interface IEquatable<T>
    {
        bool Equals(T obj);
    }
    /// //Объявление классов
    //+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
    class Animal
    {        
        virtual public string animal
        {
            get;
            set;
        }

        virtual public string animal_type
        {
            get;
            set;
        }

        virtual public int age
        {
            get;
            set;
        }

        virtual public string FavoriteFood
        {
            get;
            set;
        }
        virtual public string Location
        {
            get;
            set;
        }
    }
    //Млекопитающие++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
    class Hamster : Animal , IEquatable<Animal>
    {
        public override string animal
        {
            get
            {
                return "Млекопитающее";
            }
        }
        public override string animal_type
        {
            get 
            { 
                return "Хомяк"; 
            }
        }
        int m_age;
        string m_Location;
        string m_FavoriteFood;
        int m_kolvoAnimalInCage;
        public Hamster()
        {
            Random rand = new Random();
            m_age = rand.Next(0, 4);
            m_kolvoAnimalInCage = rand.Next(0, 5);
            Dictionary<int, string> Locations = new Dictionary<int, string>(4);
            Locations.Add(1, "Двухэтажная клетка для хомяков");
            Locations.Add(2, "Одноэтажная клетка для хомяков");
            Locations.Add(3, "Большая клетка для хомяков");
            Locations.Add(4, "Маленькая клетка для хомяков");
            m_Location = Locations[rand.Next(1, 5)];
            Dictionary<int, string> FavoritFoods = new Dictionary<int, string>(3);
            FavoritFoods.Add(1, "Морковка");
            FavoritFoods.Add(2, "Орехи");
            FavoritFoods.Add(3, "Крупа");
            m_FavoriteFood = FavoritFoods[rand.Next(1, 4)];

        }
        public override int age
        {
            get
            {
                Random rand = new Random();
                m_age += rand.Next(0, 1);
                return m_age;
            }
        }
        public override string Location
        {
            get
            {
                return m_Location;
            }
        }

        public override string FavoriteFood
        {
            get
            {
                return m_FavoriteFood;
            }
        }
        public virtual int kolvoAnimalInCage
        {
            get
            {
                return m_kolvoAnimalInCage;
            }
        }
        public bool Equals(Animal animal)
        {
            return (this.animal, this.animal_type, this.age, this.Location, this.FavoriteFood) ==
                (animal.animal, animal.animal_type, animal.age, animal.Location, animal.FavoriteFood);
        }
        public override string ToString()
        {
            return $"Семейство:{animal}, Вид:{animal_type}, Возраст:{age}, Расположение: {Location}, Любимая еда:{FavoriteFood}, Колличество сожителей:{kolvoAnimalInCage}";
        }
    }

    class Cat : Animal, IEquatable<Animal>
    {
        public override string animal
        {
            get
            {
                return "Млекопитающее";
            }
        }
        public override string animal_type
        {
            get
            {
                return "Кошка";
            }
        }
        int m_age;
        string m_Location;
        string m_FavoriteFood;
        string m_VolumeOfCat;
        public Cat()
        {
            Random rand = new Random();
            m_age = rand.Next(0, 15);
            
            Dictionary<int, string> Locations = new Dictionary<int, string>(4);
            Locations.Add(1, "Вольер");
            Locations.Add(2, "Квартира");
            Locations.Add(3, "Дача");
            Locations.Add(4, "Улица");
            m_Location = Locations[rand.Next(1, 5)];
            Dictionary<int, string> FavoritFoods = new Dictionary<int, string>(3);
            FavoritFoods.Add(1, "Мясо");
            FavoritFoods.Add(2, "Корм");
            FavoritFoods.Add(3, "Рыба");
            Dictionary<int, string> ClassOfVolumes = new Dictionary<int, string>(3);
            ClassOfVolumes.Add(1, "Тихо");
            ClassOfVolumes.Add(2, "Средне");
            ClassOfVolumes.Add(3, "Горомко");
            m_VolumeOfCat = ClassOfVolumes[rand.Next(1, 4)];
            m_FavoriteFood = FavoritFoods[rand.Next(1, 4)];

        }
        public override int age
        {
            get
            {
                Random rand = new Random();
                m_age += rand.Next(-1, 1);
                return m_age;
            }
        }
        public override string Location
        {
            get
            {
                return m_Location;
            }
        }

        public override string FavoriteFood
        {
            get
            {
                return m_FavoriteFood;
            }
        }
        public virtual string VolumeOfCat
        {
            get
            {
                return m_VolumeOfCat;
            }
        }
        public bool Equals(Animal animal)
        {
            return (this.animal, this.animal_type, this.age, this.Location, this.FavoriteFood) ==
                (animal.animal, animal.animal_type, animal.age, animal.Location, animal.FavoriteFood);
        }
        public override string ToString()
        {
            return $"Семейство:{animal}, Вид:{animal_type}, Возраст:{age}, Расположение: {Location}, Любимая еда:{FavoriteFood}, Громкость:{VolumeOfCat}";
        }
    }

    class Dog : Animal, IEquatable<Animal>
    {
        public override string animal
        {
            get
            {
                return "Млекопитающее";
            }
        }
        public override string animal_type
        {
            get
            {
                return "Собака";
            }
        }
        int m_age;
        string m_Location;
        string m_FavoriteFood;
        string m_FriendlyOfDog;
        public Dog()
        {
            Random rand = new Random();
            m_age = rand.Next(0, 20);

            Dictionary<int, string> Locations = new Dictionary<int, string>(4);
            Locations.Add(1, "Вольер");
            Locations.Add(2, "Квартира");
            Locations.Add(3, "Дача");
            Locations.Add(4, "Улица");
            m_Location = Locations[rand.Next(1, 5)];
            Dictionary<int, string> FavoritFoods = new Dictionary<int, string>(3);
            FavoritFoods.Add(1, "Мясо");
            FavoritFoods.Add(2, "Корм");
            FavoritFoods.Add(3, "Рыба");
            Dictionary<int, string> ClassOfFriendly = new Dictionary<int, string>(3);
            ClassOfFriendly.Add(1, "Очень дружелюбна");
            ClassOfFriendly.Add(2, "Абсолютное безразличие");
            ClassOfFriendly.Add(3, "Может съесть");
            m_FriendlyOfDog = ClassOfFriendly[rand.Next(1, 4)];
            m_FavoriteFood = FavoritFoods[rand.Next(1, 4)];

        }
        public override int age
        {
            get
            {
                Random rand = new Random();
                m_age += rand.Next(-1, 1);
                return m_age;
            }
        }
        public override string Location
        {
            get
            {
                return m_Location;
            }
        }

        public override string FavoriteFood
        {
            get
            {
                return m_FavoriteFood;
            }
        }
        public virtual string FriendlyOfDog
        {
            get
            {
                return m_FriendlyOfDog;
            }
        }
        public bool Equals(Animal animal)
        {
            return (this.animal, this.animal_type, this.age, this.Location, this.FavoriteFood) ==
                (animal.animal, animal.animal_type, animal.age, animal.Location, animal.FavoriteFood);
        }
        public override string ToString()
        {
            return $"Семейство:{animal}, Вид:{animal_type}, Возраст:{age}, Расположение: {Location}, Любимая еда:{FavoriteFood}, Дружелюбие:{FriendlyOfDog}";
        }
    }

    class Fox : Animal, IEquatable<Animal>
    {
        public override string animal
        {
            get
            {
                return "Млекопитающее";
            }
        }
        public override string animal_type
        {
            get
            {
                return "Лиса";
            }
        }
        int m_age;
        string m_Location;
        string m_FavoriteFood;
        string m_HealthOfFox;
        public Fox()
        {
            Random rand = new Random();
            m_age = rand.Next(0, 12);

            Dictionary<int, string> Locations = new Dictionary<int, string>(4);
            Locations.Add(1, "Вольер");
            Locations.Add(2, "Квартира");
            Locations.Add(3, "Дача");
            Locations.Add(4, "Лес");
            m_Location = Locations[rand.Next(1, 5)];
            Dictionary<int, string> FavoritFoods = new Dictionary<int, string>(3);
            FavoritFoods.Add(1, "Мясо");
            FavoritFoods.Add(2, "Корм");
            FavoritFoods.Add(3, "Рыба");
            Dictionary<int, string> ClassOfHealth = new Dictionary<int, string>(3);
            ClassOfHealth.Add(1, "Здорова");
            ClassOfHealth.Add(2, "Легкое заболевание");
            ClassOfHealth.Add(3, "Тяжёлое заболевание");
            m_HealthOfFox = ClassOfHealth[rand.Next(1, 4)];
            m_FavoriteFood = FavoritFoods[rand.Next(1, 4)];

        }
        public override int age
        {
            get
            {
                Random rand = new Random();
                m_age += rand.Next(-1, 1);
                return m_age;
            }
        }
        public override string Location
        {
            get
            {
                return m_Location;
            }
        }

        public override string FavoriteFood
        {
            get
            {
                return m_FavoriteFood;
            }
        }
        public virtual string HealthOfFox
        {
            get
            {
                return m_HealthOfFox;
            }
        }
        public bool Equals(Animal animal)
        {
            return (this.animal, this.animal_type, this.age, this.Location, this.FavoriteFood) ==
                (animal.animal, animal.animal_type, animal.age, animal.Location, animal.FavoriteFood);
        }
        public override string ToString()
        {
            return $"Семейство:{animal}, Вид:{animal_type}, Возраст:{age}, Расположение: {Location}, Любимая еда:{FavoriteFood}, Здоровье:{HealthOfFox}";
        }
    }

        class Camel : Animal, IEquatable<Animal>
    {
        public override string animal
        {
            get
            {
                return "Млекопитающее";
            }
        }
        public override string animal_type
        {
            get
            {
                return "Верблюд";
            }
        }
        int m_age;
        string m_Location;
        string m_FavoriteFood;
        string m_ColorOfCamel;
        public Camel()
        {
            Random rand = new Random();
            m_age = rand.Next(0, 12);

            Dictionary<int, string> Locations = new Dictionary<int, string>(4);
            Locations.Add(1, "Вольер");
            Locations.Add(2, "Зоопарк");
            Locations.Add(3, "Питомник");
            Locations.Add(4, "Пустыня");
            m_Location = Locations[rand.Next(1, 5)];
            Dictionary<int, string> FavoritFoods = new Dictionary<int, string>(3);
            FavoritFoods.Add(1, "Сено");
            FavoritFoods.Add(2, "Кактусы");
            FavoritFoods.Add(3, "Фрукты");
            Dictionary<int, string> ClassOfColors = new Dictionary<int, string>(3);
            ClassOfColors.Add(1, "Красновато-серая");
            ClassOfColors.Add(2, "Тёмно-бура");
            m_ColorOfCamel = ClassOfColors[rand.Next(1, 3)];
            m_FavoriteFood = FavoritFoods[rand.Next(1, 4)];

        }
        public override int age
        {
            get
            {
                Random rand = new Random();
                m_age += rand.Next(-1, 1);
                return m_age;
            }
        }
        public override string Location
        {
            get
            {
                return m_Location;
            }
        }

        public override string FavoriteFood
        {
            get
            {
                return m_FavoriteFood;
            }
        }
        public virtual string ColorOfCamel
        {
            get
            {
                return m_ColorOfCamel;
            }
        }
        public bool Equals(Animal animal)
        {
            return (this.animal, this.animal_type, this.age, this.Location, this.FavoriteFood) ==
                (animal.animal, animal.animal_type, animal.age, animal.Location, animal.FavoriteFood);
        }
        public override string ToString()
        {
            return $"Семейство:{animal}, Вид:{animal_type}, Возраст:{age}, Расположение: {Location}, Любимая еда:{FavoriteFood}, Цвет:{ColorOfCamel}";
        }
    }
    //+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

    //Птицы++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
    class Parrot : Animal, IEquatable<Animal>
    {
        public override string animal
        {
            get
            {
                return "Птица";
            }
        }
        public override string animal_type
        {
            get
            {
                return "Папугай";
            }
        }
        int m_age;
        string m_Location;
        string m_FavoriteFood;
        string m_SexOfParrot;
        public Parrot()
        {
            Random rand = new Random();
            m_age = rand.Next(0, 6);

            Dictionary<int, string> Locations = new Dictionary<int, string>(4);
            Locations.Add(1, "Вольер");
            Locations.Add(2, "Зоопарк");
            Locations.Add(3, "Питомник");
            Locations.Add(4, "Джунгли");
            m_Location = Locations[rand.Next(1, 5)];
            Dictionary<int, string> FavoritFoods = new Dictionary<int, string>(3);
            FavoritFoods.Add(1, "Корм");
            FavoritFoods.Add(2, "Зерно");
            FavoritFoods.Add(3, "Насекомые");
            Dictionary<int, string> Sex = new Dictionary<int, string>(3);
            Sex.Add(1, "Самка");
            Sex.Add(2, "Самец");
            m_SexOfParrot = Sex[rand.Next(1, 3)];
            m_FavoriteFood = FavoritFoods[rand.Next(1, 4)];

        }
        public override int age
        {
            get
            {
                Random rand = new Random();
                m_age += rand.Next(0, 1);
                return m_age;
            }
        }
        public override string Location
        {
            get
            {
                return m_Location;
            }
        }

        public override string FavoriteFood
        {
            get
            {
                return m_FavoriteFood;
            }
        }
        public virtual string SexOfParrot
        {
            get
            {
                return m_SexOfParrot;
            }
        }
        public bool Equals(Animal animal)
        {
            return (this.animal, this.animal_type, this.age, this.Location, this.FavoriteFood) ==
                (animal.animal, animal.animal_type, animal.age, animal.Location, animal.FavoriteFood);
        }
        public override string ToString()
        {
            return $"Семейство:{animal}, Вид:{animal_type}, Возраст:{age}, Расположение: {Location}, Любимая еда:{FavoriteFood}, Пол:{SexOfParrot}";
        }
    }

    class Hawk : Animal, IEquatable<Animal>
    {
        public override string animal
        {
            get
            {
                return "Птица";
            }
        }
        public override string animal_type
        {
            get
            {
                return "Ястреб";
            }
        }
        int m_age;
        string m_Location;
        string m_FavoriteFood;
        string m_ConditionOfHawk;
        public Hawk()
        {
            Random rand = new Random();
            m_age = rand.Next(0, 9);

            Dictionary<int, string> Locations = new Dictionary<int, string>(4);
            Locations.Add(1, "Вольер");
            Locations.Add(2, "Зоопарк");
            Locations.Add(3, "Питомник");
            Locations.Add(4, "На воле");
            m_Location = Locations[rand.Next(1, 5)];
            Dictionary<int, string> FavoritFoods = new Dictionary<int, string>(3);
            FavoritFoods.Add(1, "Корм");
            FavoritFoods.Add(2, "Мыши");
            FavoritFoods.Add(3, "Мясо");
            Dictionary<int, string> Conditions = new Dictionary<int, string>(3);
            Conditions.Add(1, "Приручен");
            Conditions.Add(2, "Свободен");
            m_ConditionOfHawk = Conditions[rand.Next(1, 3)];
            m_FavoriteFood = FavoritFoods[rand.Next(1, 4)];

        }
        public override int age
        {
            get
            {
                Random rand = new Random();
                m_age += rand.Next(0, 1);
                return m_age;
            }
        }
        public override string Location
        {
            get
            {
                return m_Location;
            }
        }

        public override string FavoriteFood
        {
            get
            {
                return m_FavoriteFood;
            }
        }
        public virtual string ConditionOfHawk
        {
            get
            {
                return m_ConditionOfHawk;
            }
        }
        public bool Equals(Animal animal)
        {
            return (this.animal, this.animal_type, this.age, this.Location, this.FavoriteFood) ==
                (animal.animal, animal.animal_type, animal.age, animal.Location, animal.FavoriteFood);
        }
        public override string ToString()
        {
            return $"Семейство:{animal}, Вид:{animal_type}, Возраст:{age}, Расположение: {Location}, Любимая еда:{FavoriteFood}, Состояние:{ConditionOfHawk}";
        }
    }

    class Owl : Animal, IEquatable<Animal>
    {
        public override string animal
        {
            get
            {
                return "Птица";
            }
        }
        public override string animal_type
        {
            get
            {
                return "Сова";
            }
        }
        int m_age;
        string m_Location;
        string m_FavoriteFood;
        string m_ConditionOfOwl;
        public Owl()
        {
            Random rand = new Random();
            m_age = rand.Next(0, 10);

            Dictionary<int, string> Locations = new Dictionary<int, string>(4);
            Locations.Add(1, "Вольер");
            Locations.Add(2, "Зоопарк");
            Locations.Add(3, "Питомник");
            Locations.Add(4, "На воле");
            m_Location = Locations[rand.Next(1, 5)];
            Dictionary<int, string> FavoritFoods = new Dictionary<int, string>(3);
            FavoritFoods.Add(1, "Корм");
            FavoritFoods.Add(2, "Мыши");
            FavoritFoods.Add(3, "Мясо");
            Dictionary<int, string> Conditions = new Dictionary<int, string>(3);
            Conditions.Add(1, "Приручена");
            Conditions.Add(2, "Свободена");
            m_ConditionOfOwl = Conditions[rand.Next(1, 3)];
            m_FavoriteFood = FavoritFoods[rand.Next(1, 4)];

        }
        public override int age
        {
            get
            {
                Random rand = new Random();
                m_age += rand.Next(0, 1);
                return m_age;
            }
        }
        public override string Location
        {
            get
            {
                return m_Location;
            }
        }

        public override string FavoriteFood
        {
            get
            {
                return m_FavoriteFood;
            }
        }
        public virtual string ConditionOfOwl
        {
            get
            {
                return m_ConditionOfOwl;
            }
        }
        public bool Equals(Animal animal)
        {
            return (this.animal, this.animal_type, this.age, this.Location, this.FavoriteFood) ==
                (animal.animal, animal.animal_type, animal.age, animal.Location, animal.FavoriteFood);
        }
        public override string ToString()
        {
            return $"Семейство:{animal}, Вид:{animal_type}, Возраст:{age}, Расположение: {Location}, Любимая еда:{FavoriteFood}, Состояние:{ConditionOfOwl}";
        }
    }

    class Cock : Animal, IEquatable<Animal>
    {
        public override string animal
        {
            get
            {
                return "Птица";
            }
        }
        public override string animal_type
        {
            get
            {
                return "Петух";
            }
        }
        int m_age;
        string m_Location;
        string m_FavoriteFood;
        string m_ConditionOfCock;
        public Cock()
        {
            Random rand = new Random();
            m_age = rand.Next(0, 6);

            Dictionary<int, string> Locations = new Dictionary<int, string>(4);
            Locations.Add(1, "Вольер");
            Locations.Add(2, "Зоопарк");
            Locations.Add(3, "Ферма");
            Locations.Add(4, "На воле");
            m_Location = Locations[rand.Next(1, 5)];
            Dictionary<int, string> FavoritFoods = new Dictionary<int, string>(3);
            FavoritFoods.Add(1, "Корм");
            FavoritFoods.Add(2, "Зерно");            
            Dictionary<int, string> Conditions = new Dictionary<int, string>(3);
            Conditions.Add(1, "Боевой");
            Conditions.Add(2, "Спокойный");
            m_ConditionOfCock = Conditions[rand.Next(1, 3)];
            m_FavoriteFood = FavoritFoods[rand.Next(1, 3)];

        }
        public override int age
        {
            get
            {
                Random rand = new Random();
                m_age += rand.Next(0, 1);
                return m_age;
            }
        }
        public override string Location
        {
            get
            {
                return m_Location;
            }
        }

        public override string FavoriteFood
        {
            get
            {
                return m_FavoriteFood;
            }
        }
        public virtual string ConditionOfCock
        {
            get
            {
                return m_ConditionOfCock;
            }
        }
        public bool Equals(Animal animal)
        {
            return (this.animal, this.animal_type, this.age, this.Location, this.FavoriteFood) ==
                (animal.animal, animal.animal_type, animal.age, animal.Location, animal.FavoriteFood);
        }
        public override string ToString()
        {
            return $"Семейство:{animal}, Вид:{animal_type}, Возраст:{age}, Расположение: {Location}, Любимая еда:{FavoriteFood}, Поведение:{ConditionOfCock}";
        }
    }

    class Duck : Animal, IEquatable<Animal>
    {
        public override string animal
        {
            get
            {
                return "Птица";
            }
        }
        public override string animal_type
        {
            get
            {
                return "Утка";
            }
        }
        int m_age;
        string m_Location;
        string m_FavoriteFood;
        string m_ConditionOfDuck;
        public Duck()
        {
            Random rand = new Random();
            m_age = rand.Next(0, 6);

            Dictionary<int, string> Locations = new Dictionary<int, string>(4);
            Locations.Add(1, "Озеро");
            Locations.Add(2, "Зоопарк");
            Locations.Add(3, "Ферма");
            Locations.Add(4, "На воле");
            m_Location = Locations[rand.Next(1, 5)];
            Dictionary<int, string> FavoritFoods = new Dictionary<int, string>(3);
            FavoritFoods.Add(1, "Хлеб");
            FavoritFoods.Add(2, "Зерно");
            Dictionary<int, string> Conditions = new Dictionary<int, string>(3);
            Conditions.Add(1, "Хорошо летает");
            Conditions.Add(2, "Плохо летает");
            m_ConditionOfDuck = Conditions[rand.Next(1, 3)];
            m_FavoriteFood = FavoritFoods[rand.Next(1, 3)];

        }
        public override int age
        {
            get
            {
                Random rand = new Random();
                m_age += rand.Next(0, 1);
                return m_age;
            }
        }
        public override string Location
        {
            get
            {
                return m_Location;
            }
        }

        public override string FavoriteFood
        {
            get
            {
                return m_FavoriteFood;
            }
        }
        public virtual string ConditionOfDuck
        {
            get
            {
                return m_ConditionOfDuck;
            }
        }
        public bool Equals(Animal animal)
        {
            return (this.animal, this.animal_type, this.age, this.Location, this.FavoriteFood) ==
                (animal.animal, animal.animal_type, animal.age, animal.Location, animal.FavoriteFood);
        }
        public override string ToString()
        {
            return $"Семейство:{animal}, Вид:{animal_type}, Возраст:{age}, Расположение: {Location}, Любимая еда:{FavoriteFood}, Полёт:{ConditionOfDuck}";
        }
    }
    //Рыьы+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
    class Seahorse : Animal, IEquatable<Animal>
    {
        public override string animal
        {
            get
            {
                return "Рыба";
            }
        }
        public override string animal_type
        {
            get
            {
                return "Морской конёк";
            }
        }
        int m_age;
        string m_Location;
        string m_FavoriteFood;
        string m_SexOfSeahorse;
        public Seahorse()
        {
            Random rand = new Random();
            m_age = rand.Next(0, 6);

            Dictionary<int, string> Locations = new Dictionary<int, string>(4);
            Locations.Add(1, "Океан");
            Locations.Add(2, "Аквариум");
            Locations.Add(3, "Море");
            Locations.Add(4, "Зоопарк");
            m_Location = Locations[rand.Next(1, 5)];
            Dictionary<int, string> FavoritFoods = new Dictionary<int, string>(3);
            FavoritFoods.Add(1, "Хлеб");
            FavoritFoods.Add(2, "Корм");
            Dictionary<int, string> Sex = new Dictionary<int, string>(3);
            Sex.Add(1, "Самка");
            Sex.Add(2, "Самец");
            m_SexOfSeahorse = Sex[rand.Next(1, 3)];
            m_FavoriteFood = FavoritFoods[rand.Next(1, 3)];

        }
        public override int age
        {
            get
            {
                Random rand = new Random();
                m_age += rand.Next(0, 1);
                return m_age;
            }
        }
        public override string Location
        {
            get
            {
                return m_Location;
            }
        }

        public override string FavoriteFood
        {
            get
            {
                return m_FavoriteFood;
            }
        }
        public virtual string SexOfSeahorse
        {
            get
            {
                return m_SexOfSeahorse;
            }
        }
        public bool Equals(Animal animal)
        {
            return (this.animal, this.animal_type, this.age, this.Location, this.FavoriteFood) ==
                (animal.animal, animal.animal_type, animal.age, animal.Location, animal.FavoriteFood);
        }
        public override string ToString()
        {
            return $"Семейство:{animal}, Вид:{animal_type}, Возраст:{age}, Расположение: {Location}, Любимая еда:{FavoriteFood}, Пол:{SexOfSeahorse}";
        }
    }

    class GoldenFish : Animal, IEquatable<Animal>
    {
        public override string animal
        {
            get
            {
                return "Рыба";
            }
        }
        public override string animal_type
        {
            get
            {
                return "Золотая рыбка";
            }
        }
        int m_age;
        string m_Location;
        string m_FavoriteFood;
        string m_SexOfGoldenFish;
        public GoldenFish()
        {
            Random rand = new Random();
            m_age = rand.Next(0, 6);

            Dictionary<int, string> Locations = new Dictionary<int, string>(4);
            Locations.Add(1, "Океан");
            Locations.Add(2, "Аквариум");
            Locations.Add(3, "Море");
            Locations.Add(4, "Зоопарк");
            m_Location = Locations[rand.Next(1, 5)];
            Dictionary<int, string> FavoritFoods = new Dictionary<int, string>(3);
            FavoritFoods.Add(1, "Хлеб");
            FavoritFoods.Add(2, "Корм");
            Dictionary<int, string> Sex = new Dictionary<int, string>(3);
            Sex.Add(1, "Самка");
            Sex.Add(2, "Самец");
            m_SexOfGoldenFish = Sex[rand.Next(1, 3)];
            m_FavoriteFood = FavoritFoods[rand.Next(1, 3)];

        }
        public override int age
        {
            get
            {
                Random rand = new Random();
                m_age += rand.Next(0, 1);
                return m_age;
            }
        }
        public override string Location
        {
            get
            {
                return m_Location;
            }
        }

        public override string FavoriteFood
        {
            get
            {
                return m_FavoriteFood;
            }
        }
        public virtual string SexOfSeahorse
        {
            get
            {
                return m_SexOfGoldenFish;
            }
        }
        public bool Equals(Animal animal)
        {
            return (this.animal, this.animal_type, this.age, this.Location, this.FavoriteFood) ==
                (animal.animal, animal.animal_type, animal.age, animal.Location, animal.FavoriteFood);
        }
        public override string ToString()
        {
            return $"Семейство:{animal}, Вид:{animal_type}, Возраст:{age}, Расположение: {Location}, Любимая еда:{FavoriteFood}, Пол:{SexOfSeahorse}";
        }
    }
    //Пресмыкающиеся+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
    class  Snake : Animal, IEquatable<Animal>
    {
        public override string animal
        {
            get
            {
                return "Пресмыкающиеся";
            }
        }
        public override string animal_type
        {
            get
            {
                return "Змея";
            }
        }
        int m_age;
        string m_Location;
        string m_FavoriteFood;
        string m_SexOfSnake;
        public Snake()
        {
            Random rand = new Random();
            m_age = rand.Next(0, 40);

            Dictionary<int, string> Locations = new Dictionary<int, string>(4);
            Locations.Add(1, "Джунгли");
            Locations.Add(2, "Террариум");
            Locations.Add(3, "Поле");
            Locations.Add(4, "Зоопарк");
            m_Location = Locations[rand.Next(1, 5)];
            Dictionary<int, string> FavoritFoods = new Dictionary<int, string>(3);
            FavoritFoods.Add(1, "Мышы");
            FavoritFoods.Add(2, "Жабы");
            Dictionary<int, string> Sex = new Dictionary<int, string>(3);
            Sex.Add(1, "Самка");
            Sex.Add(2, "Самец");
            m_SexOfSnake = Sex[rand.Next(1, 3)];
            m_FavoriteFood = FavoritFoods[rand.Next(1, 3)];

        }
        public override int age
        {
            get
            {
                Random rand = new Random();
                m_age += rand.Next(0, 1);
                return m_age;
            }
        }
        public override string Location
        {
            get
            {
                return m_Location;
            }
        }

        public override string FavoriteFood
        {
            get
            {
                return m_FavoriteFood;
            }
        }
        public virtual string SexOfSnake
        {
            get
            {
                return m_SexOfSnake;
            }
        }
        public bool Equals(Animal animal)
        {
            return (this.animal, this.animal_type, this.age, this.Location, this.FavoriteFood) ==
                (animal.animal, animal.animal_type, animal.age, animal.Location, animal.FavoriteFood);
        }
        public override string ToString()
        {
            return $"Семейство:{animal}, Вид:{animal_type}, Возраст:{age}, Расположение: {Location}, Любимая еда:{FavoriteFood}, Пол:{SexOfSnake}";
        }
    }

    class Chamelion : Animal, IEquatable<Animal>
    {
        public override string animal
        {
            get
            {
                return "Пресмыкающиеся";
            }
        }
        public override string animal_type
        {
            get
            {
                return "Хамелион";
            }
        }
        int m_age;
        string m_Location;
        string m_FavoriteFood;
        string m_SexOfChamelion;
        public Chamelion()
        {
            Random rand = new Random();
            m_age = rand.Next(0, 11);

            Dictionary<int, string> Locations = new Dictionary<int, string>(4);
            Locations.Add(1, "Джунгли");
            Locations.Add(2, "Террариум");
            Locations.Add(3, "Поле");
            Locations.Add(4, "Зоопарк");
            m_Location = Locations[rand.Next(1, 5)];
            Dictionary<int, string> FavoritFoods = new Dictionary<int, string>(3);
            FavoritFoods.Add(1, "Мухи");
            FavoritFoods.Add(2, "Кузнечики");
            Dictionary<int, string> Sex = new Dictionary<int, string>(3);
            Sex.Add(1, "Самка");
            Sex.Add(2, "Самец");
            m_SexOfChamelion = Sex[rand.Next(1, 3)];
            m_FavoriteFood = FavoritFoods[rand.Next(1, 3)];

        }
        public override int age
        {
            get
            {
                Random rand = new Random();
                m_age += rand.Next(0, 1);
                return m_age;
            }
        }
        public override string Location
        {
            get
            {
                return m_Location;
            }
        }

        public override string FavoriteFood
        {
            get
            {
                return m_FavoriteFood;
            }
        }
        public virtual string SexOfSnake
        {
            get
            {
                return m_SexOfChamelion;
            }
        }
        public bool Equals(Animal animal)
        {
            return (this.animal, this.animal_type, this.age, this.Location, this.FavoriteFood) ==
                (animal.animal, animal.animal_type, animal.age, animal.Location, animal.FavoriteFood);
        }
        public override string ToString()
        {
            return $"Семейство:{animal}, Вид:{animal_type}, Возраст:{age}, Расположение: {Location}, Любимая еда:{FavoriteFood}, Пол:{SexOfSnake}";
        }
    }
    //+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
    public partial class MainWindow : Window
    {


        //++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        List<Animal> ListOfAnimals = new List<Animal>();
        public MainWindow()
        {
           
            InitializeComponent();
            
        }

        //Нажатия кнопок в меню
        //++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

        //Добавление пресмыкающегося
        //_____________________________________________________________________________



        private void ChoosenChamelion_Click(object sender, RoutedEventArgs e)
        {
            ListOfAnimals.Add(new Chamelion { });
            updateListBox(ListOfAnimals);
        }

        private void ChoosenSnake_Click(object sender, RoutedEventArgs e)
        {
            ListOfAnimals.Add(new Snake { });
            updateListBox(ListOfAnimals);
        }
        //_____________________________________________________________________________



        //Добавление млекопитающего
        //_____________________________________________________________________________


        private void ChoosenCamel_Click(object sender, RoutedEventArgs e)
        {
            ListOfAnimals.Add(new Camel { });
            updateListBox(ListOfAnimals);
        }

        private void ChoosenFox_Click(object sender, RoutedEventArgs e)
        {
            ListOfAnimals.Add(new Fox { });
            updateListBox(ListOfAnimals);
        }

        private void ChoosenDog_Click(object sender, RoutedEventArgs e)
        {
            ListOfAnimals.Add(new Dog { });
            updateListBox(ListOfAnimals);
        }

        private void ChoosenCat_Click(object sender, RoutedEventArgs e)
        {
            ListOfAnimals.Add(new Cat { });
            updateListBox(ListOfAnimals);
        }

        private void ChoosenHamster_Click(object sender, RoutedEventArgs e)
        {
            ListOfAnimals.Add(new Hamster { });
            updateListBox(ListOfAnimals);
        }
        //____________________________________________________________________________


        //Добавление птицы
        //____________________________________________________________________________


        private void ChoosenDuck_Click(object sender, RoutedEventArgs e)
        {
            ListOfAnimals.Add(new Duck { });
            updateListBox(ListOfAnimals);
        }

        private void ChoosenCock_Click(object sender, RoutedEventArgs e)
        {
            ListOfAnimals.Add(new Cock { });
            updateListBox(ListOfAnimals);
        }

        private void ChoosenOwl_Click(object sender, RoutedEventArgs e)
        {
            ListOfAnimals.Add(new Owl { });
            updateListBox(ListOfAnimals);
        }

        private void ChoosenHawk_Click(object sender, RoutedEventArgs e)
        {
            ListOfAnimals.Add(new Hawk { });
            updateListBox(ListOfAnimals);
        }

        private void ChoosenParrot_Click(object sender, RoutedEventArgs e)
        {
            ListOfAnimals.Add(new Parrot { });
            updateListBox(ListOfAnimals);
        }
        //___________________________________________________________________________



        //Добавление рыбы
        //___________________________________________________________________________


        private void ChoosenSeahorse_Click(object sender, RoutedEventArgs e)
        {
            ListOfAnimals.Add(new Seahorse { });
            updateListBox(ListOfAnimals);
        }


        private void ChoosenGoldenFish_Click(object sender, RoutedEventArgs e)
        {
            ListOfAnimals.Add(new GoldenFish { });
            updateListBox(ListOfAnimals);
        }
        //_________________________________________________________________________

        //+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

        //Сортировки
        //+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        private void SortByFish_Click(object sender, RoutedEventArgs e)
        {
            var Fishes = ListOfAnimals.Where(x => x.animal == "Рыба");
            string result = Fishes.Aggregate("Рыбы:\n", (s, x) => s+=$"Вид {x.animal_type}, Возраст {x.age}, Любимая еда {x.FavoriteFood}, Место расположения {x.Location}\n");
            MessageBox.Show(result);
        }

        private void SortByBird_Click(object sender, RoutedEventArgs e)
        {
            var Birds = ListOfAnimals.Where(x => x.animal == "Птица");
            string result = Birds.Aggregate("Птицы:\n", (s, x) => s += $"Вид {x.animal_type}, Возраст {x.age}, Любимая еда {x.FavoriteFood}, Место расположения {x.Location}\n");
            MessageBox.Show(result);
        }

        private void SortByMammals_Click(object sender, RoutedEventArgs e)
        {
            var Mammals = ListOfAnimals.Where(x => x.animal == "Млекопитающее");
            string result = Mammals.Aggregate("Млекопитающие:\n", (s, x) => s += $"Вид {x.animal_type}, Возраст {x.age}, Любимая еда {x.FavoriteFood}, Место расположения {x.Location}\n");
            MessageBox.Show(result);
        }

        private void SortByReptiles_Click(object sender, RoutedEventArgs e)
        {
            var Fishes = ListOfAnimals.Where(x => x.animal == "Пресмыкающиеся");
            string result = Fishes.Aggregate("Пресмыкающиеся:\n", (s, x) => s += $"Вид {x.animal_type}, Возраст {x.age}, Любимая еда {x.FavoriteFood}, Место расположения {x.Location}\n");
            MessageBox.Show(result);
        }

        private void SortByAge_Click(object sender, RoutedEventArgs e)
        {
            var OldestAnimals = ListOfAnimals.Where(x => x.age > 5);
            string result = OldestAnimals.Aggregate("Животные:\n", (s, x) => s += $"Семейство {x.animal} Вид {x.animal_type}, Возраст {x.age}, Любимая еда {x.FavoriteFood}, Место расположения {x.Location}\n");
            MessageBox.Show(result);
        }
        private void SortByAgeBirds_Click(object sender, RoutedEventArgs e)
        {

        }
        //+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        void updateListBox(List<Animal> animals)
        {
            LbAnimals.Items.Clear();

            foreach (var animal in animals)
            {
                LbAnimals.Items.Add(animal);
            }
        }

        private void Bt1Del_Click(object sender, RoutedEventArgs e)
        {
            if (LbAnimals.SelectedIndex > -1)
            {
                LbAnimals.Items.RemoveAt(LbAnimals.SelectedIndex);
                ListOfAnimals.Remove(ListOfAnimals[LbAnimals.SelectedIndex+1]);
            }
        }


    }
}
