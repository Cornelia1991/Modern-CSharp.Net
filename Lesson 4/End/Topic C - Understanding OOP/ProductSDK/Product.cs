using System;

namespace ProductSDK
{
    public class Product
    {
        /// <summary>
        /// 1. What - abstraction
        /// 2. How
        /// 3. Made complicated methods private - encapsulation
        /// </summary>
        public string ProductID { get; set; }
        public string ProductName { get; set; }

        public void Submit()
        {
            // Add to database
            Validate();
            ConnectToDB();
        }

        //Granular methods
        private bool Validate()
        {
            // ProductID & ProductName
            return true;
        }

        private bool ConnectToDB()
        {
            //DB Connect SQL
            return true;
        }
    }
}
