using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant
{
    public enum AccountType
    {
        Client,
        Admin
    }


    public class MenuRest<T> where T : Account
    {
        T account;

        public MenuRest(AccountType accountType) : base()
        {
            switch(accountType)
            {
                case AccountType.Client:
                    account = new ClientAccount() as T;
                    break;
                case AccountType.Admin:
                    account = new AdminAccount() as T;
                    break;
            }
        }

        public List<Dish> GetDish()
        {
            return account.dishes;
        }

        public List<Ingredient> GetIngredients()
        {
            return account.ingredients;
        }

        public bool isNameRepeat(string repeat)
        {
            return account.isNameRepeat(repeat);
        }

        public Ingredient getIngredientByID(int id_ingredient_)
        {
            return account.getIngredientByID(id_ingredient_);
        }

        public List<Dish> getDishesBySection(string section_)
        {
            return account.getDishesBySection(section_);
        }

        public Dish getDishByName(string name_)
        {
            return account.getDishByName(name_);
        }

        public int getIndexDishByName(string name_)
        {
            return account.getIndexDishByName(name_);
        }

        public Ingredient FindIngredient(string name_, bool is_editable_)
        {
            return account.FindIngredient(name_, is_editable_);
        }

        public int GetIndexIngrByName(string name_)
        {
            return account.GetIndexIngrByName(name_);
        }

        public void Remove(int index, string name_)
        {
            account.Remove(index, name_);
        }
    }
}
