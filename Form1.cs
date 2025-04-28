namespace Assignment_4._1._1
{
    public partial class Form1 : Form
    {
        public Dictionary<string, Person> contacts = new Dictionary<string, Person>();

        public Form1()
        {
            InitializeComponent();
            // initial seed data
            contacts.Add("John Smith", new Person("John", "Smith", "123-456-2385", "456-222-1111", "New York City"));
            contacts.Add("Alice Smith", new Person("Alice", "Smith", "123-456-2386", "456-222-1111", "New York City"));
            
            RefreshList();
        }

        private void FindPerson(object sender, EventArgs e)
        {
            try
            { 
            List<Person> person = new List<Person>();
            person.Add(contacts[searchTextBoxName.Text]);
            dataGridView1.DataSource = person;
            }
            catch
            { 
                RefreshList();
            }
        }
        private void RefreshList()
        {
            List<Person> addressList = new List<Person>();
            foreach ((string key, Person person) in contacts)
            {
                addressList.Add(person);
            }
            dataGridView1.DataSource = addressList;
        }
    }
}
