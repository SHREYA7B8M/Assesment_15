using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Assesment_15
{
    public partial class SquareRoot : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                LblMsg.Visible = false;
            }
        }

        protected void BtnClick_Click(object sender, EventArgs e)
        {
            LblMsg.Visible = true;

            try
            {
                double number=double.Parse(TxtSqRoot.Text);
                if (number < 0) 
                {

                    throw new ArgumentException("Input must be a non-negative number");
                }
                double result=Math.Sqrt(number);
                LblMsg.Text = $"Square root of {number} is {result:F2}";

            }
            catch (FormatException ex)

            {
                //LblMsg.Text="An error occured!!"+ex.Message;
                Session["error"] = "An error occured!!" + ex.Message;
                Response.Redirect("Error.aspx");
            }
            catch (ArgumentException ex)
            {
                //LblMsg.Text = "An error encountered!!" + ex.Message;
                Session["error"] = "An error has been encountered!!" + ex.Message;
                Response.Redirect("Error.aspx");
            }
            catch(Exception ex)
            {
                //LblMsg.Text = "An error arose !!" + ex.Message;
                Session["error"] = "An error has arose!!" + ex.Message;
                Response.Redirect("Error.aspx");
            }
        }

    }
}