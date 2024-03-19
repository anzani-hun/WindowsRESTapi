using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*ez kell hozzá a http-k miatt*/
using System.Net.Http;

namespace WindowsRESTapi
{
    public partial class Form1 : Form
    {
        string endPointUrl = "https://retoolapi.dev/KqpqJ9/data";

        static List<Dolgozo> adatok = new List<Dolgozo>();

        public Form1()
        {
            InitializeComponent();
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            await restapiAdatok();
            listBox_Adatok.Items.AddRange(adatok.ToArray());

        }

        private async void restapiAdatok()
        {
            var client = new HttpClient();
            var request = new HttpRequestMessage(HttpMethod.Get, endPointUrl);
            var response = await client.SendAsync(request);
            
            if (response.IsSuccessStatusCode)
            {
                string jsonString = await response.Content.ReadAsStringAsync();
                adatok = Dolgozo.FromJson(jsonString);
            }

        }

    }
}
