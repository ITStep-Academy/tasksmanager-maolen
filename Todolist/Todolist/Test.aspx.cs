using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Todolist
{
    public partial class Test : System.Web.UI.Page
    {
        public int Counter { get; set; } = 0;
        protected void Page_Load(object sender, EventArgs e)
        {
            count.Text = Counter.ToString();
        }

        protected void Unnamed_Click(object sender, EventArgs e)
        {
            Counter++;
            count.Text = Counter.ToString();
        }
    }
}