using SQLite;

namespace CustomerApp.Date {
    public class Customer {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string Name { get; set; } = "";
        public string Phone { get; set; } = "";
        public string PostalCode { get; set; } = "";
        public string Address { get; set; } = "";
        public string ImagePath { get; set; } = "";
    }
}