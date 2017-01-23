using System.Collections.Generic;


namespace JAMK_IT
{
    class Fridge
    {
        public List<FoodStuff> EatTable = new List<FoodStuff>();
        public void Add(FoodStuff stuff)
        {
            EatTable.Add(stuff);
        }
        public void Take(FoodStuff stuff)
        {
            EatTable.Remove(stuff);
        }
        public string Contains()
        {
            string tmp = "";
            List<FoodStuff> sisalto = new List<FoodStuff>();
            foreach (FoodStuff a in EatTable)
            {
                if (!sisalto.Contains(a))
                    sisalto.Add(a);
            }
            int[] count = new int[sisalto.Count];
            foreach (FoodStuff a in EatTable)
            {
                count[sisalto.IndexOf(a)]++;
            }
            for (int i = 0; i < sisalto.Count; i++)
            {
                if (i != sisalto.Count -1)
                    tmp += count[i].ToString() + " " + sisalto[i].Name + ", ";
                else
                    tmp += count[i].ToString() + " " + sisalto[i].Name + ".";
            }
            return tmp;
        }
        public bool HasItem(string tmp)
        {
            FoodStuff food = new FoodStuff(tmp);
            foreach (FoodStuff stuff in EatTable)
            {
                if (stuff.Name == food.Name)
                    return true;
            }
            return false;
        }
        public FoodStuff Copy(string tmp)
        {
            FoodStuff food = new FoodStuff(tmp);
            foreach (FoodStuff stuff in EatTable)
            {
                if (stuff.Name == food.Name)
                    return stuff;
            }
            return food;
        }
    }
    class FoodStuff
    {
        public string Name { get; set; }
        public FoodStuff(string name)
        {
            Name = name;
        }
    }
    class Food : FoodStuff
    {
        public Food(string name):base(name){ }
    }
    class Drink : FoodStuff
    {
        public Drink(string name):base(name){}
    }
}
