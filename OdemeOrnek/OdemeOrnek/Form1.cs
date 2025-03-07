using LogOrnek;

namespace OdemeOrnek
{
    public partial class Form1 : Form
    {
        
        public string odemeTipi = "";
        public string mesaj = "";
        public ILogger logger;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
        
            try
            {
                string className = "OdemeOrnek." + odemeTipi + "Odeme"; // �deme tipine g�re s�n�f ad� olu�turuluyor
                Type type = Type.GetType(className);

                if (type != null)
                {
                    object instance = Activator.CreateInstance(type);
                    IOdeme odeme = instance;
                    if (odeme != null)
                    {
                        mesaj = odeme.odemeYap(textBox1.Text);
                        lblSonuc.Text = mesaj;
                    }
                    else
                    {
                        lblSonuc.Text = "Hatal� log s�n�f�!";
                    }
                }
                else
                {
                    lblSonuc.Text = "Bilinmeyen �deme tipi!";
                }
            }
            catch (Exception ex)
            {
                lblSonuc.Text = "Hata: " + ex.Message;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            logTipi = comboBox1.SelectedItem.ToString();
        }
    }
}
