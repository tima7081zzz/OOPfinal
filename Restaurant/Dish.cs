using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Restaurant
{
    public class Dish
    {
        public int id_dish { get; private set; }
        public string name { get; private set; }
        public int price { get; private set; }
        public int weight { get; private set; }
        public List<Ingredient> structure { get; private set; }
        public string section { get; private set; }
        public int num_of_portion { get; private set; }


        public Dish(int id_dish_, string name_, int price_, int weight_, List<Ingredient> input_, String section_)
        {
            id_dish = id_dish_;
            name = name_;
            price = price_;
            weight = weight_;
            structure = input_;
            section = section_;
            num_of_portion = 1;
        }

        public Dish(int id_dish_, string name_, int price_, int weight_, String section_)
        {
            id_dish = id_dish_;
            name = name_;
            price = price_;
            weight = weight_;
            section = section_;
            num_of_portion = 1;
        }

        public void SetStructure(List<Ingredient> structure_)
        {
            structure = new List<Ingredient>(structure_);
        }


        public void Remove(string name_)//removing ingredient
        {
            foreach (var item in structure)
            {
                if(item.Name == name_)
                {
                    structure.Remove(item);
                    return;
                }
            }
        }

        public void setPortion(int portion_)
        {
            if(portion_<1)
            {
                throw new Exception("You should order at least one porion of a dish");
            }
            num_of_portion = portion_;
        }

        public void ChangeNumOfPortion(int i)
        {
            //exception nado nah
            num_of_portion += i;
        }

        public void CalcPrice() // recalculating price because of changing of the portion
        {
            price = price * num_of_portion;
        }
    }
}
