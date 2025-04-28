namespace Assignment_4._1._1
{
    public partial class Form1 : Form
    {
        public Dictionary<string, Person> contacts = new Dictionary<string, Person>();

        public Form1()
        {
            InitializeComponent();
            SeedData();

            RefreshList();
        }

        private void FindPersonEvent(object sender, EventArgs e)
        {
            try
            {
                List<Person> person = new List<Person>();
                person.Add(contacts[searchTextBoxName.Text.ToLower()]);
                personBindingSource.DataSource = person;
            }
            catch
            {
                // Display all result if the search key doesn't exist
                RefreshList();
            }
        }

        private void NewContactEvent(object sender, EventArgs e)
        {
            AddToContacts(new Person(addTextBoxFirstName.Text, addTextBoxLastName.Text,
                addTextBoxMobile.Text, addTextBoxWork.Text, addTextBoxAddress.Text));
            RefreshList();
        }

        private void ConfirmDelete(object sender, EventArgs e)
        {
            buttonRemove.Enabled = removeCheckBox.Checked;
        }

        private void RemoveContactEvent(object sender, EventArgs e)
        {
            contacts.Remove(removeTextBoxName.Text.ToLower());
            RefreshList();
            removeCheckBox.Checked = false;
        }

        private void RefreshList()
        {
            personBindingSource.DataSource = null;
            personBindingSource.DataSource = contacts.Values;
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = personBindingSource;
        }
        private void SeedData()
        {
            AddToContacts(new Person("John", "Smith", "123-456-2385", "456-222-1111", "New York City"));
            AddToContacts(new Person("Alice", "Smith", "123-456-2386", "456-222-1111", "New York City"));
            AddToContacts(new Person("Bryce", "Johnson", "345-678-3752", "456-222-1133", "San Francisco"));
        }
        private void AddToContacts(Person person)
        {
            try { contacts.Add(person.FullName.ToLower(), person); }
            catch { contacts[person.FullName.ToLower()] = person; }
        }


    }
}
