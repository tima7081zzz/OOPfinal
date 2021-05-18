using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant
{
    public enum Delivery
    {
        pickup,
        courier
    }

    public class Order
    {
        public int price {get; private set;}
        public List<Dish> wishes{get; private set;}
        public Delivery delivery { get; set; }
        public delegate void OrderHandler(string message);
        public event OrderHandler Notify;

        public Order() { price = 0; wishes = new List<Dish>(); }

        public Order(Dish wish_)
        {
            price = 0;
            wishes = new List<Dish>();
            wishes.Add(wish_);
            price += wish_.price;

            Notify?.Invoke($"You added {wish_.name}!");
        }

        public void AddDish(Dish wish_)
        {
            wishes.Add(wish_);
            price += wish_.price;

            Notify?.Invoke($"You added {wish_.name}!");
            CalcPrice();
        }

        public void RemoveDishByName(string name)
        {
            //exception for index
            foreach(var item in wishes)
            {
                if(name == item.name)
                {
                    wishes.Remove(item);
                    price -= item.price*item.num_of_portion;
                    return;
                }
            }
        }

        public void SetPortionByName(string name_, int portion_)
        {
            foreach(var item in wishes)
            {
                if(item.name == name_)
                {
                    item.setPortion(portion_);
                }
            }
            CalcPrice();
        }

        public void CalcPrice()
        {
            int result = 0;
            foreach(var item in wishes)
            {
                result += item.price*item.num_of_portion;
            }
            price = result;
        }
    }
}
