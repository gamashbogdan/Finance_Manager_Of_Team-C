using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Finance_Manager_Of_Team_C.Income_User_Control
{
    public partial class UC_Wallet : UserControl
    {
        public UC_Wallet()
        {
            InitializeComponent();
            BindClass();
        }

        public class DataClass
        {
            public int ID { get; set; }
            public string Name { get; set; }
        }

        // Initialize myList with some sample data
        public List<DataClass> myList = new List<DataClass>
        {
            new DataClass { ID = 1, Name = "John" },
            new DataClass { ID = 2, Name = "Alice" },
            new DataClass { ID = 3, Name = "Bob" }
            // Add more items as needed
        };

        public void BindClass()
        {
            dataGridViewWallets.DataSource = myList.Select(myClass => new { myClass.ID, myClass.Name }).ToList();
        }
    }
}
