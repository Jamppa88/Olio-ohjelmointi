
namespace JAMK_IT
{
    enum Sex { Male, Female }
    abstract class Person
    {
        public virtual string Name { get; set; }
        public virtual int Age { get; set; }
        public virtual Sex Sex { get; set; }

        public Person(string name, int age, Sex sex)
        {
            Name = name;
            Age = age;
            Sex = sex;
        }
        abstract public string SayHi();
    }

    class Child: Person
    {
        private int age;

        public override int Age
        {
            get { return age; }
            set
            {
                if (value >= 0 && value < 18)
                    age = value;
            }
        }

        public Child(string name, int age, Sex sex)
            :base(name, age, sex) { }
        
        public override string SayHi()
        {
            return "Ugugaga!";
        }
        public string EatBooger()
        {
            return "Nomnom";
        }
        public string NoEatBooger()
        {
            return "Yääää!!!";
        }
    }
    class Adult: Person
    {
        private int age;

        public override int Age
        {
            get { return age; }
            set
            {
                if (value >= 18 && value <= 100)
                    age = value;
            }
        }

        public Adult(string name, int age, Sex sex)
            :base(name, age, sex) { }

        public override string SayHi()
        {
            return "Hi there!";
        }
        public string DoWork()
        {
            return "Napunapunapunapu...";
        }
        public string DontWork()
        {
            return "Kossshhhhh...(gulpgulpgulp)";
        }
    }
}
