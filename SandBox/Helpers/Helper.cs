using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc.Rendering;


namespace SandBox.Helper
{
    public static class Helper
    {
        public static HtmlString Create(this IHtmlHelper html, string[] items, string type)
        {
            string result = "<ul type=\"" + type + "\">";
            foreach (string item in items)
            {
                result = result + "<li>" + item + "</li>";
            }
            result = result + "</ul>";
            HtmlString htmlString = new HtmlString(result);
            return htmlString;
        }
        public static HtmlString LoginForm(this IHtmlHelper html, string name, int method)
        {
            string result = "<form method=\"" + method + "\">";
            result += "<input type =\"text\" name=\"" + name + "_login\"/><br>";
            result += "<input type =\"password\" name=\"" + name + "_password\"/><br>";
            result += "<input type = \"submit\" value=\"Login\" />";
            result = result + "</form>";
            HtmlString htmlString = new HtmlString(result);
            return htmlString;
        }
    }
}
