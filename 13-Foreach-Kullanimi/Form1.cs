using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _13_Foreach_Kullanimi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] sehirler = { "Ankara", "Edirne", "İstanbul", "Eskişehir", "Bursa", "Trabzon", "Sivas", "Malatya" ,"Zonguldak"};

            foreach (string sehir in sehirler)
            {
                MessageBox.Show($@"{sehir}");
            }

            //string ifadesinin bulunduğu alan veri tipini temsil etmektedir.
            //sehir ifadesinin bulunduğu alan değişken adımızı belirtmektedir.
            //in ifadesi ifadesinin bulunduğu alanda ise kaynak yapısı işaret edilmektedir.
            //sehirler ifadesinin bulunduğu alan ise dönülecek veri kaynağını ifade etmektedir.

        }
    }
}
