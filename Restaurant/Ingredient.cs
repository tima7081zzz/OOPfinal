using System;


namespace Restaurant
{
    public class Ingredient
    {
        public int id_ingredient { get; private set; }

        public string Name;
        public bool IsEditable;
        

        public Ingredient(int id_ingredient_, String name_, bool IsEditable_)
        {
            id_ingredient = id_ingredient_;
            Name = name_;
            IsEditable = IsEditable_;
        }
    }
}
