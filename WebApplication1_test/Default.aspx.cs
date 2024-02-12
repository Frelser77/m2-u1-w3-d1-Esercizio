using System;
using System.Configuration;
using System.Web.UI;

namespace WebApplication1_test
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            // scrivi il codice per cambiare il colore di sfondo del bottone in rosso
            Button1.BackColor = System.Drawing.Color.Gray;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            // scrivi il codice per cambiare il testo del bottone in "Clicked" e in click me se gia cliccato
            if (Button1.Text == "Click me")
            {
                Button1.Text = "Clicked";
            }
            else if (Button1.Text == "Clicked")
            {
                Button1.Text = "Click me";
            }

            //Response.Write(DateTime.Now);
            if (Button1.Text == "Clicked")
            {
                Label1.Text = ConfigurationManager.AppSettings["Name"] + "  " + ConfigurationManager.AppSettings["Surname"];
            }
            else if (Button1.Text == "Click me")
                Label1.Text = "Clicca per visualizzare il nome e cognome";



            if (Button1.Text == "Clicked")
            {
                Button1.BackColor = System.Drawing.Color.LightGray;
            }
            else if (Button1.Text == "Click me")
                Button1.BackColor = System.Drawing.Color.Gray;




        }
    }
}