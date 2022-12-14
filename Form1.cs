using System.Drawing.Text;

namespace Joppes_Djurfamilj_UI_Forms
{
    public partial class Form1 : Form
    {
        PetOwner MyOwner = new PetOwner();
        ListBox listbox2 = new ListBox();
        int index;
        public Form1()
        {
            InitializeComponent();
            ListBox listbox1 = new ListBox();
            listbox1.Name = "ListBox1";
            listbox1.Size = new System.Drawing.Size(300, 20);
            listbox1.Location = new System.Drawing.Point(0, 10);
            listbox1.BackColor = Color.DarkGoldenrod;
            listbox1.ForeColor = Color.White;
            listbox1.BorderStyle = BorderStyle.FixedSingle;
            MyOwner.pets.Add(new Dog("Fido", 3, "Labradoodle"));
            MyOwner.pets.Add(new Cat("Meowzer", 6, "Maine Coon"));
            MyOwner.pets.Add(new Puppy("Elsa", 0, 4, "Cocker Spaniel"));
            MyOwner.Name = "Benny";
            MyOwner.Age = 25;
            Controls.Add(listbox1);
            
            listbox1.Items.Add(MyOwner);

            
            listbox2.Name = "ListBox1";
            listbox2.Size = new System.Drawing.Size(400, 60);
            listbox2.Location = new System.Drawing.Point(0, 30);
            listbox2.BackColor = Color.Green;
            listbox2.ForeColor = Color.White;
            listbox2.BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(listbox2);
            listbox2.DataSource= MyOwner.pets;

            Button Select = new Button();
            Select.Name = "Select";
            Select.Size = new System.Drawing.Size(100, 25);
            Select.Text = "Select Animal";
            Select.Location = new System.Drawing.Point(0, 80);
            Controls.Add(Select);
            Select.Click += new System.EventHandler(this.Select_Click);

            Button BtnFeed = new Button();
            BtnFeed.Name = "Feed";
            BtnFeed.Size = new System.Drawing.Size(100, 25);
            BtnFeed.Text = "Feed Animal";
            BtnFeed.Location = new System.Drawing.Point(0, 250);
            BtnFeed.BackColor= Color.Green;
            BtnFeed.ForeColor = Color.White;
            Controls.Add((BtnFeed));
            BtnFeed.Click += new System.EventHandler(this.BtnFeed_Click);

            Button Catnip = new Button();
            Catnip.Name = "Catnip";
            Catnip.Size = new System.Drawing.Size(100, 25);
            Catnip.Text = "Catnip";
            Catnip.Location = new System.Drawing.Point(300, 250);
            Controls.Add(Catnip);
            Catnip.Click += new System.EventHandler(this.Catnip_Click);

            Button Steak = new Button();
            Steak.Name = "Steak";
            Steak.Size = new System.Drawing.Size(100, 25);
            Steak.Text = "Steak";
            Steak.Location = new System.Drawing.Point(400, 250);
            Controls.Add(Steak);
            Steak.Click += new System.EventHandler(this.Steak_Click);





        }

        private void Select_Click(object sender, EventArgs e)
        {
            MyOwner.Selector = listbox2.SelectedIndex;
            MessageBox.Show($"Pet has been selected! Its name is: {MyOwner.pets[listbox2.SelectedIndex].name}");
        }

        private void Steak_Click(object? sender, EventArgs e)
        {
            MyOwner.FoodOUT = "Steak";
        }

        private void Catnip_Click(object? sender, EventArgs e)
        {
            MyOwner.FoodOUT = "Catnip";
        }

        private void BtnFeed_Click(object? sender, EventArgs e)
        {
            
            MyOwner.Feed();
            
        }

        


    }
}