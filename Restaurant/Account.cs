using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant
{
    public abstract class Account : IAccount
    {
        public List<Ingredient> ingredients { get; private set; } //all engridients from menu
        public List<Dish> dishes { get; private set; }//all dishes from menu

        protected internal event AccountStateHandler DishChanged;
        protected void CallEvent(AccountEventArgs e, AccountStateHandler handler)
        {
            if(e!=null)
            {
                handler?.Invoke(this, e);
            }
        }

        protected virtual void OnDishChanged(AccountEventArgs e)
        {
            CallEvent(e, DishChanged);
        }

        public Account()
        {
            //reading information from MySQL DataBase

            //reading ingrediets

            ingredients = new List<Ingredient>();
            DB db = new DB();
            db.openConnection();
            MySqlCommand command = new MySqlCommand("Select * from `ingredients`", db.getConnection());
            MySqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                int id = Convert.ToInt32(reader["id_ingredients"]);
                string name = reader["name"].ToString();
                bool is_aditable = Convert.ToInt32(reader["is_editable"]) > 0 ? true : false;

                ingredients.Add(new Ingredient(id, name, is_aditable));
            }
            reader.Close();

            //reading dishes

            dishes = new List<Dish>();
            string abv = "SELECT * FROM `dish` " +
                "JOIN `section-dish` ON dish.id_dish = `section-dish`.id_dish " +
                "JOIN section ON `section-dish`.id_section = section.id_section " +
                "JOIN `ingredient-dish` ON dish.id_dish = `ingredient-dish`.id_dish ";


            command = new MySqlCommand(abv, db.getConnection());
            reader = command.ExecuteReader();

            while (reader.Read())
            {
                int id_dish_ = Convert.ToInt32(reader["id_dish"]);
                string name_ = reader["name"].ToString();
                int price = Convert.ToInt32(reader["price"]);
                int weight = Convert.ToInt32(reader["weight"]);
                int id_section_ = Convert.ToInt32(reader["id_section"]);
                string section_ = reader["section_name"].ToString();

                if (isNameRepeat(name_) == false)
                {
                    dishes.Add(new Dish(id_dish_, name_, price, weight, section_));
                }
            }
            reader.Close();

            // reading dependences betwwen ingredients and dishes
            List<Ingredient> structure = new List<Ingredient>();
            foreach (var item in dishes)
            {
                int id_dish_ = item.id_dish;
                command = new MySqlCommand($"SELECT * FROM `ingredient-dish` WHERE id_dish = {id_dish_}", db.getConnection());
                reader = command.ExecuteReader();

                while (reader.Read())
                {
                    structure.Add(getIngredientByID(Convert.ToInt32(reader["id_ingredient"])));
                }
                item.SetStructure(structure);
                structure.Clear();
                reader.Close();
            }
            db.closeConnection();
        }

        public bool isNameRepeat(string repeat)
        {
            foreach (var item in dishes)
            {
                if (repeat == item.name)
                {
                    return true;
                }
            }

            return false;
        }

        public Ingredient getIngredientByID(int id_ingredient_)
        {
            foreach (var item in ingredients)
            {
                if (item.id_ingredient == id_ingredient_)
                {
                    return item;
                }
            }
            return null;
        }

        public virtual void Remove(int index, string name_) // removing ingredient from the dish
        {
            dishes[index].Remove(name_);
            OnDishChanged(new AccountEventArgs($"{dishes[index].name} was changed"));
        }

        public List<Dish> getDishesBySection(string section_)
        {
            List<Dish> result = new List<Dish>();
            foreach (var item in dishes)
            {
                if (item.section == section_)
                {
                    result.Add(item);
                }
            }

            return result;
        }

        public Dish getDishByName(string name_)
        {
            foreach (var item in dishes)
            {
                if (item.name == name_)
                {
                    return item;
                }
            }

            return null;
        }

        public int getIndexDishByName(string name_)
        {
            int index = 1;
            foreach (var item in dishes)
            {
                if (item.name == name_)
                {
                    return index;
                }
                index++;
            }
            return -1;
        }

        public Ingredient FindIngredient(string name_, bool is_editable_)
        {
            foreach (var item in ingredients)
            {
                if (item.Name == name_ && item.IsEditable == is_editable_)
                {
                    return item;
                }
            }
            return null;
        }

        public int GetIndexIngrByName(string name_)
        {
            foreach(var item in ingredients)
            {
                if(item.Name == name_)
                {
                    return item.id_ingredient;
                }
            }
            return -1;
        }
    }
}
