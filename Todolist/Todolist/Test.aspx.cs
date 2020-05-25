using System;
using System.Web.UI;

namespace Todolist
{
    public partial class Test : Page
    {
        public int counter = 0;
        protected void Page_Load(object sender, EventArgs e)
        {
            if(Session["counter"] == null)
            {
                Session["counter"] = counter;
            }
            count.Text = Session["counter"].ToString();
        }

        protected void Unnamed_Click(object sender, EventArgs e)
        {
            counter = (int)Session["counter"];
            counter++;
            count.Text = counter.ToString();
            Session["counter"] = counter;
        }
    }
}