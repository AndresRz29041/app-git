using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AppCapas
{
    public partial class index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void calcular_click(object sender, EventArgs e)
        {

            double a = 2;
            double b = 2;
            double c = 2;
            double y = 0;

            try
            {
                double x = Convert.ToDouble(this.txt_x.Text);
                y = ((a) * Math.Pow(x, 2)) + b * (x) + c;
                this.txt_y.Text = Convert.ToString(y);
            }
            catch (Exception)
            {
                Console.WriteLine("Error obteniendo x");
                this.txt_x.Text = Convert.ToString(0);
                this.txt_y.Text = Convert.ToString(0);
            }
        }
    }
}