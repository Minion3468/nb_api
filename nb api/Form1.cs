using System.Linq;
using System.Xml.Linq;

namespace nb_api
{
    public partial class Form1 : Form
    {
        private Dictionary<string, float>_rates = new Dictionary<string, float>();
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            XDocument api = XDocument.Load("http://api.nbp.pl/api/exchangerates/tables/a/?format=xml");

            //richTextBox1.Text = api.ToString();
            
            var rates = api.Descendants("Rate");
            _rates.Clear();
            foreach (var rate in rates)
            {
                string code = rate.Element("Code").Value;
                float mid = float.Parse(rate.Element("Mid").Value, System.Globalization.CultureInfo.InvariantCulture);

                _rates.Add(code, mid);
            }
            //TextBox.Text = _rates.ToString();

            USDRateTextBox.Text = _rates["USD"].ToString();
            EURRateTextBox.Text = _rates["EUR"].ToString();
            CHFRateTextBox.Text = _rates["CHF"].ToString();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Exchange(object sender, EventArgs e)
        {
            RadioButton radio = sender as RadioButton;
            string code = radio.Text;
            float pln = float.Parse(PLNtextBox.Text);
            float exchanged = pln / _rates[code];
            textBox2.Text = exchanged.ToString();

        }
    }
}