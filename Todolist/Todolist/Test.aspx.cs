using System;
using System.Web.UI;

namespace Todolist
{
    public partial class Test : Page
    {
        public int counter = 0;
        protected void Page_Load(object sender, EventArgs e)
        {
            if(ViewState["counter"] == null)
            {
                ViewState["counter"] = counter;
            }
            count.Text = ViewState["counter"].ToString();
        }

        protected void Unnamed_Click(object sender, EventArgs e)
        {
            counter = (int)ViewState["counter"];
            counter++;
            count.Text = counter.ToString();
            ViewState["counter"] = counter;
        }
    }
}