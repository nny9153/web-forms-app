using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GETREST;

namespace Project3
{
    public partial class DetailsUndegrad1 : Form
    {
        public DetailsUndegrad1()
        {
            InitializeComponent();
            Start();
        }

        GetClass get;
        Degrees degrees;
        private void Start()
        {
            //get the title of undegrad degree 1
            get = new GetClass();
            string jsonDegrees = get.GET("/degrees/");
            degrees = JToken.Parse(jsonDegrees).ToObject<Degrees>();

            titleUndergrad1.Text = degrees.undergraduate[0].title;

            //create ListView
           for ( int i= 0;  i < degrees.undergraduate[0].concentrations.Count; i++)
            {
                concentrationsUndergrad1.Items.Add(degrees.undergraduate[0].concentrations[i]);
            }






        }
    }
}
