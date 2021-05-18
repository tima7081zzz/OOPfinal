using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant
{
    public class AdminAccount : Account
    {
        public AdminAccount() : base() { }

        public override void Remove(int index_ingr, string indexDish)
        {
            int index_dish = int.Parse(indexDish);
            DB db = new DB();
            db.openConnection();

            // deleting ingredient out of sctructure if the dish

            MySqlCommand command = new MySqlCommand($"DELETE FROM `ingredient-dish` WHERE id_dish = {index_dish} AND id_ingredient = {index_ingr}", db.getConnection());
            command.ExecuteNonQuery();
            db.closeConnection();
        }
    }
}
