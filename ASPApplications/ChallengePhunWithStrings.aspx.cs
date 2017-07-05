using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASPApplications
{
    public partial class ChallengePhunWithStrings : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //1. Reverse you name:
            //string myName = "Usman Tarfa";
            // In the case the result should be:
            // afraT namsU
            /*
             for (int i = myName.Length - 1; i >= 0; i--)
            {
                resultLabel.Text += myName[i];
            }
             */


            //2. Reverse this sequence:
            //string names = "Luke,Leia,Han,Chewbacca";
            // When you're finished it should look like this:
            // Chewbacca,Han,Leia,Luke
            /*
             string result = "";
            string[] values = names.Split(',');
            for (int i = values.Length - 1; i >= 0; i--)
            {
                result += values[i] + ",";
            }
            result = result.Remove(result.Length - 1, 1);
            resultLabel.Text = result;
             */


            //3. Use the sequence to create ascii art:
            //*****Luke***** 
            //*****Leia*****
            //*****Han******
            //**Chewbacca***
            /*
             * TODO:
             * Take the total length of luke (which is 14)
             * subtract out the length of luke(4)
             * divide the remainder by (2) [10/2 = 5(represents (5) char' on both sides of luke(4))]
             * pad the left by (5) 
             * pad the right with a total of (14) char'
             */

            /*
           string result = "";
           string[] rebelScum = names.Split(',');
           for (int i = 0; i < rebelScum.Length; i++)
           {
               int padleft = (14 - rebelScum[i].Length) / 2;
               string temp = rebelScum[i].PadLeft(rebelScum[i].Length + padleft, '*');
               result += temp.PadRight(14, '*');
               result += "<br/>";

           }
           resultLabel.Text = result;
             */

 
            //4. Solve this puzzle"
            string puzzle = "NOW IS ZHEremove-me ZIME FOR ALL GOOD MEN ZO COME ZO ZHE AID OF ZHEIR COUNZRY";
            //Once you fix it with string helper methods, it should read:
            //Now is the time for all good men to come to the aid of their country

            //remove the remove-me
            string removeMe = "remove-me";
            int index = puzzle.IndexOf(removeMe);
            puzzle = puzzle.Remove(index, removeMe.Length);
            puzzle = puzzle.ToLower();
            puzzle = puzzle.Replace('z', 't');
            puzzle = puzzle.Remove(0, 1);
            puzzle = puzzle.Insert(0, "N");

            resultLabel.Text = puzzle;
        }

        protected void Button_Click(object sender, EventArgs e)
        {
            
        }
    }
}