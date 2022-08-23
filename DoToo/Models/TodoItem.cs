using System;
using SQLite;

namespace DoToo.Models
{
    public class TodoItem
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string Title { get; set; }
        public bool Completed { get; set; }
        public DateTime Due { get; set; }

        public string Description { get; set; }
        public string category = "Home";

        public string Category
        {
            get { return category; }
            set
            {
                if (value == "Home" || value == "Personal" || value == "School")
                {
                    category = value;
                }
                else
                {
                    category = "Home";
                }
            }

        }
    }
}
