using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;
using System.Net;
using System.IO;
using GETREST;
using System.Diagnostics;

namespace Project3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Start();
        }

        About about;
        People people;
        Degrees degrees;
        Staff staff;
        Employment employment;
        Footer footer;
        CoopTable coopTable;
        GetClass get;

        private void Start()
        {
            //get the about
            get = new GetClass();
        
            // get people
            string jsonPeople = get.GET("/people/");
            people = JToken.Parse(jsonPeople).ToObject<People>();
           
            //get degrees
            string jsonDegrees = get.GET("/degrees/");
            degrees = JToken.Parse(jsonDegrees).ToObject<Degrees>();

            //get employment
            string jsonEmployment = get.GET("/employment/");
            employment = JToken.Parse(jsonEmployment).ToObject<Employment>();

            //get footer
            string jsonFooter = get.GET("/footer/");
            footer = JToken.Parse(jsonFooter).ToObject<Footer>();
            lb_socialTitle.Text = footer.social.title;
            lbtweet.Text = footer.social.tweet;

            ///////////////TwitterLink//////////////////////

            LinkLabel.Link facebookLink = new LinkLabel.Link();
            facebookLink.LinkData = footer.social.facebook;
            link_facebook.Text = "Facebook";
            link_facebook.Links.Add(facebookLink);

            LinkLabel.Link twitterLink = new LinkLabel.Link();
            twitterLink.LinkData = footer.social.twitter;
            link_twitter.Text = "Twitter";
            link_twitter.Links.Add(twitterLink);

            ////////////////About/////////////////////////////////
            string jsonAbout = get.GET("/about/");
            about = JToken.Parse(jsonAbout).ToObject<About>();
            //Console.WriteLine(jsonAbout);
            lbl_about_title.Text = about.title;
            lbl_about_description.Text = about.description;
            lbl_about_quote.Text = "\"" + about.quote + "\"";
            lbl_about_quoteAuthor.Text = "~" + about.quoteAuthor;

            //Console.WriteLine(jsonDegrees);

            int x = 20;
            int y = 20;

            foreach (Undergraduate allDegrees in degrees.undergraduate)
            {
                //create objects
                Label labelTitle = new Label();
                Label labelDescription = new Label();
                ListBox concentrationsListBox = new ListBox();

                //properties
                labelDescription.Location = new Point(x, 130);
                concentrationsListBox.Location = new Point(x, 300);
                labelTitle.Location = new Point(x, y);
                x += 400;

                // labelTitle location
                labelTitle.AutoSize = false;
                labelTitle.Height = 100;
                labelTitle.Width = 200;

                labelDescription.AutoSize = false;
                labelDescription.Height = 100;
                labelDescription.Width = 250;

                concentrationsListBox.Height = 100;
                concentrationsListBox.Width = 250;

                // lopp to get all concentrations
                for (int i = 0; i < allDegrees.concentrations.Count(); i++)
                {
                    concentrationsListBox.Items.Add(allDegrees.concentrations[i]);
                }

                this.tabUndergradDegree.Controls.Add(labelTitle);
                this.tabUndergradDegree.Controls.Add(labelDescription);
                this.tabUndergradDegree.Controls.Add(concentrationsListBox);


                labelTitle.Text = allDegrees.title;
                labelDescription.Text = allDegrees.description;

                ////////////////////Faculty Listview///////////////////////////

                // populates listView

                foreach (Faculty member in people.faculty)
                {
                    ListViewItem memberItem = new ListViewItem(new String[]
                        {
                     member.name,
                     member.username,
                     member.tagline,
                     member.title,
                     member.interestArea,
                     member.office,
                     member.website,
                     member.phone,
                     member.email,
                     member.facebook,
                     member.twitter
                        }
               );

                    peopleListView.Items.Add(memberItem);

                }


                foreach (Staff staff in people.staff)
                {
                    ListViewItem staffItem = new ListViewItem(new String[]
                        {
                     staff.name,
                     staff.username,
                     staff.tagline,
                     staff.title,
                     staff.interestArea,
                     staff.office,
                     staff.website,
                     staff.phone,
                     staff.email,
                     staff.facebook,
                     staff.twitter
                        }
               );

                    staffListView.Items.Add(staffItem);

                }

              
            }

        }
    

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //for map
            System.Diagnostics.Process.Start("http://ist.rit.edu/api/map");
        }

        private void tabPage3_Enter(object sender, EventArgs e)
        {

        }

        private void tabAbout_Click(object sender, EventArgs e)
        {
            //get the about
              
        }


        private void tabUndergradDegree_Click(object sender, EventArgs e)
        {
            // code is in Start() because the Undergrad Degrees tabgoes first
        }
  
      

        private void udergradGroupBox_Enter(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void lbl_about_quoteAuthor_Click(object sender, EventArgs e)
        {

        }

        private void lbl_about_quote_Click(object sender, EventArgs e)
        {

        }

        private void labelTitle_Click(object sender, EventArgs e)
        {

        }

        private void tabPeople_Click1(object sender, EventArgs e)
        {  
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void tabEmployment_Click(object sender, EventArgs e)
        {
            string jsonEmployment = get.GET("/employment/");
            employment = JToken.Parse(jsonEmployment).ToObject<Employment>();
            lb_employment_title.Text = employment.introduction.title;

            int x = 0;
            int y = 0;
            for (int i=0; i < employment.introduction.content.Count; i++)
            {
                Label labelEmployment = new Label();
                tabEmployment.Controls.Add(labelEmployment);
                labelEmployment.Location = new Point(x, y);
                y += 10;
                labelEmployment.Text = "test";
            }
        }

        private void link_twitter_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(e.Link.LinkData as string);
        }

        private void link_facebook_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(e.Link.LinkData as string);
        }

        private void tabStaff_Click(object sender, EventArgs e)
 
        {

        }

        private void tb_Employment_Click(object sender, EventArgs e)
        {
            string jsonEmployment = get.GET("/employment/");
            employment = JToken.Parse(jsonEmployment).ToObject<Employment>();

            lb_employment_title.Text = employment.introduction.title;
            lb_title1.Text = employment.introduction.content[0].title;
            lb_description1.Text = employment.introduction.content[0].description;
        }
    }
}

   





