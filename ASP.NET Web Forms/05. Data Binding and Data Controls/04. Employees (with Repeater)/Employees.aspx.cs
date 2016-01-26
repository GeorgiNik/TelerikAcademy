﻿namespace EmployeesRepeater
{
    using System;
    using System.Linq;
    using System.Web.UI;
    using EmployeesDataBinding.Models;

    public partial class Employees : Page
    {
        private NorthwindContext northwindContext = new NorthwindContext();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.Page.IsPostBack)
            {
                this.EmployeesRepeater.DataSource = this.northwindContext.Employees.ToList();
                this.EmployeesRepeater.DataBind();
            }
        }
    }
}