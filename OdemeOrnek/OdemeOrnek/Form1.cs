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
                string className = "OdemeOrnek." + odemeTipi + "Odeme"; // Ödeme tipine göre sýnýf adý oluþturuluyor
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
                        lblSonuc.Text = "Hatalý log sýnýfý!";
                    }
                }
                else
                {
                    lblSonuc.Text = "Bilinmeyen ödeme tipi!";
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
