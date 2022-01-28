using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NopCommerce_Automation_Testing
{

    public static class Constants
    {
        public const string Login = "//a[@class='ico-login']";
        public const string Emailtxt = "//input[@class='email']";
        public const string Username = "Email";
        public const string Password = "password";
        public const string passwordtxt = "//input[@class='password']";
        public const string Loginbtn = "//button[@type='submit'][text()='Log in']";
        public const string Administrator = "//a[@class='administration'][text()='Administration']";

        //Catagol
        public static string Catalogmenu = "//ul[@class='nav nav-pills nav-sidebar flex-column nav-legacy']/li[@class='nav-item has-treeview'][1]";
        public static string Products = "//p[text()='Products']";
        public static string AddNewProductBtn = "//a[@class='btn btn-primary']";

        //Product page
        public static string ProductNametxt = "//input[@id='Name']";
        public static string ProductDescription = "//textarea[@name='ShortDescription']";
        public static string SKU = "//input[@id='Sku']";
        public static string Categoriestxt = "//div[@role='listbox']";
        public static string Categorieslist = "//li[@tabindex='-1'][@class='k-item']";

    }
}
