using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASPApplications
{
    public partial class DevSheet8 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void Button_Click(object sender, EventArgs e)
        {
            /*
             * 
            Escape double qoutes
            string myString = "This is a double qoute: \".";
            resultLabel.Text = myString;
            string value = TextBox.Text;

            Accessing a specific char:
            myString[2]

             */

            //resultLabel.Text = "<p style="color:#ee3b32;">Hi</>p";
            //Escape character: \

            //resultLabel.Text = "<p style=\"color:#ee3b32;\">Hi</p>";

            //Escape double qoutes
            //string myString = "This is a double qoute: \".";
            //resultLabel.Text = myString;


            string value = TextBox.Text;
            // Access any specific character
            //resultLabel.Text = value[2].ToString();

            //StartWith(), EndsWith(), Contains()
            /*check to see  if a given string has set of charaters
             * begining, end or somewhere inside
             * Return true/false
             */

            //if (value.StartsWith("A"))
            //    resultLabel.Text = "Value starts with 'A'";

            //if (value.EndsWith("."))
            //    resultLabel.Text += "<br />Value ends with '.'";

            //if (value.Contains("good"))
            //    resultLabel.Text += "Value contains good!";
            /* 
             * 
             */

            //IndexOf()
            /* Find the index of one string inside of 
             * another string.
             */
            int index = value.IndexOf("good");
            //resultLabel.Text = "'good' begins at index " + index.ToString();

            //Insert(), Remove()
            /* Insert add characters starting at the given index
             * Remove removes characters starting at the given index
             * and all the way through the length you input.
             */
            //resultLabel.Text = value.Insert(index, "jolly ");
            //resultLabel.Text = value.Remove(index, value.Length - index);

            //SubString()
            /* Retrieves characters beginning at the given index
             * all the way through the length you input.
             */
            //resultLabel.Text = value.Substring(index, value.Length - index - 1);

            //Trim(), TrimStart(), TrimEnd()
            /* Remove space characters both, or just the start
             * or the end of the string
             */
            //resultLabel.Text = string.Format("Length Before: {0}<br/> Leangth After: {1} ", value.Length, value.Trim().Length);

            //PadLeft(), PadRight()
            /* Allows you to specify a length for a string 
             * and a character to pad the string with if its
             * length is less than a specific length.
             *   
             * Notice that we're inputting a char, not a string
             * therefore we have to use a single qoute ' not a 
             * double quote.
             */
            //resultLabel.Text = value.PadLeft(10, '*');

            //ToUpper(), ToLower()
            /* Important! Compare two strings regardless 
             * of the case, because in C#, two strings with
             * different cases are NOT equal.
             */
            //if ("Usman" == "usman") resultLabel.Text = "The same";
            //else resultLabel.Text = "Different";
            /*
             * if (TextBox.Text.Trim().ToUpper()== "USMAN")  resultLabel.Text= "The same";
            else resultLabel.Text = "Different";
             */

            //Replace()
            /* Replace every occurancd of one string with
             * some other string
             */
            //string template = "[NAME] said it would be ok. Maybe you should take that up with [NAME].";
            //resultLabel.Text = template.Replace("[NAME]", TextBox.Text);

            //Split()
            /* This will take a string and split it into many strings
             * and store them in a string array.
             */
            //string result = "";
            //string[] values = TextBox.Text.Split(',');
            //for (int i = 0; i < values.Length; i++)
            //{
            //    result += values[i] + " " + values[i].Length + "<br/>";
            //}
            //resultLabel.Text = result;

            /* Concatenating strings, immutability
             * StringBuilder - memory efficient way of concatenating strings.
             */
            StringBuilder sb = new StringBuilder();
            
            string result = "";
            string[] values = TextBox.Text.Split(',');
            for (int i = 0; i < values.Length; i++)
            {
                //result += values[i] + " " + values[i].Length + "<br/>";
                sb.Append(values[i]);
                sb.Append(" ");
                sb.Append(values[i].Length);
                sb.Append("<br/>");
            }
            //resultLabel.Text = result;
            resultLabel.Text = sb.ToString();

        }
    }
}