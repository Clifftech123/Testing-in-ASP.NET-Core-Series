namespace AspNetCore_Testing_Part4_UnitTesting_XUnit
{
    public class TestObjectDateListICollection
    {
        public string Name { get; set; }
        public DateTime CreatedDate { get; set; }
        public List<string> StringList { get; private set; }
        public ICollection<int> NumberCollection { get; private set; }
        public Dictionary<string, object> Properties { get; private set; }


        // Constructor 
        public TestObjectDateListICollection()
        {
            Name = "Default";
            CreatedDate = DateTime.Now;
            StringList = new List<string>();
            NumberCollection = new List<int>();
            Properties = new Dictionary<string, object>();
        }

        // Constructor with parameters

        public TestObjectDateListICollection(string name, DateTime createdDate)
        {
            Name = name;
            CreatedDate = createdDate;
            StringList = new List<string>();
            NumberCollection = new List<int>();
            Properties = new Dictionary<string, object>();

        }

        // Methods to manipulate collections
        public void AddToStringList(string item)
        {
            StringList.Add(item);
        }

        public void AddToNumberCollection(int number)
        {
            NumberCollection.Add(number);
        }

        public void AddProperty(string key, object value)
        {
            if (Properties.ContainsKey(key))
            {
                Properties[key] = value;
            }
            else
            {
                Properties.Add(key, value);
            }
        }

        // Methods to test date functionality
        public bool IsCreatedToday()
        {
            return CreatedDate.Date == DateTime.Today;
        }

        public int DaysSinceCreation()
        {
            return (DateTime.Now - CreatedDate).Days;
        }

        // Method to get collection count
        public int GetTotalItemCount()
        {
            return StringList.Count + NumberCollection.Count;
        }

        // Method to clear all collections
        public void ClearAllCollections()
        {
            StringList.Clear();
            NumberCollection.Clear();
            Properties.Clear();
        }


    }
}
