﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin_ManageWaiters : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void ProcessExceptions(object sender, ObjectDataSourceStatusEventArgs e)
    {
        if (e.Exception != null)
        {
            // We can display a message
            MessageLabel.Text = "Unable to process request";
            // Prevent the error being handled by the ObjectDataSource control itsel
            e.ExceptionHandled = true; // I've dealt with the problem
        }
    }
}