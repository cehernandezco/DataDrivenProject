﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace data_driven_apps_pr
{
    public partial class Webiste : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Show current year
            
            lblYear.Text = DateTime.Now.Year.ToString();
        }
        public void setTitle(string title)
        {
            lblTitle.Text = title;
        }
        
    }
}