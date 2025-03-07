using LogOrnek;

namespace OdemeOrnek
{
    public partial class Form1 : Form
    {
        public string logTipi = "";
        public string odemeTipi = "";
        public string mesaj = "";
        public ILogger logger;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //if(odemeTipi =="Nakit")
            //{
            //    XmLog xmLog = new XmLog();
            //    mesaj = xmLog.logYaz(textBox1.Text);
            //    lblSonuc.Text = mesaj;
            //}
            //else if (logTipi == "Kredi")
            //{
            //    DbLog dbLog = new DbLog();
            //    mesaj = dbLog.logYaz(textBox1.Text);
            //    lblSonuc.Text = mesaj;
            //}
            //else if (logTipi = "Kripto")
            //{

            //}
            try
            {
                string className = "OdemeOrnek." + odemeTipi + "Odeme"; // �deme tipine g�re s�n�f ad� olu�turuluyor
                Type type = Type.GetType(className);

                if (type != null)
                {
                    object instance = Activator.CreateInstance(type);
                    ILogger logger = instance as ILogger;

                    if (logger != null)
                    {
                        mesaj = logger.logYaz(textBox1.Text);
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
