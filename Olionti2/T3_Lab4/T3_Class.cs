
namespace JAMK_IT
{
    // Aluksi pääluokka "Employee"
    class Employee
    {
        public string Name { get; set; }
        public string Profession { get; set; }
        public int Salary { get; set; }
        // Konstruktorilla annetaan arvot luokalle
        public Employee(string name, string profession, int salary)
        {
            Name = name;
            Profession = profession;
            Salary = salary;
        }
        // Lisätään metodi PrintData, jolla saadaan kaikki tieto stringinä.
        // virtual tarkoittaa, että perijä voi ylikirjoittaa metodin
        public virtual string PrintData()
        {
            string tmp = Name + ';' + Profession + ';' + Salary;
            return tmp;
        }
    }
    class Boss : Employee
    {
        public string Car { get; set; }
        public int Bonus { get; set; }

        // Otetaan base classin konstruktorista tieto
        public Boss(string name, string profession, int salary, string car, int bonus)
            :base(name, profession, salary)
        {
            Bonus = bonus;
            Car = car;
        }
        // Ylikirjoitetaan peritty metodi
        public override string PrintData()
        {
            string tmp = Name + ';' + Profession + ';' + Salary + ';' + Car + ';' + Bonus;
            return tmp;
        }
    }
}
