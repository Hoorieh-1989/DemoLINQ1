namespace DemoLINQ1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void buttonLINQ_Click(object sender, EventArgs e)

        {
            LINQstrings();

        }



        private void LINQnumbers()
        {
            List<int> numbersList = new List<int>()
            { 1,5,25,12,3,28,38,33,6,21,59};


            var result = (from number in numbersList

                          where number >= 10 && number <= 25
                          orderby number descending
                          select number).ToList();
        }

        private void LINQstrings()
        {


            List<string> contactList = new List<string>()
            { "Lisa","Kalle","Anna"};

            var result = (from contact in contactList
                          where contact.ToLower().Contains("e")
                          select contact).ToList();


            List<string> listresult = new List<string>();

            foreach (var contact in contactList)
            {

                if (contact.ToLower().Contains("e"))
                {
                }
            }
        }
    }
}