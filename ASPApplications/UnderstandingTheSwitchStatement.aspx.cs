using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASPApplications
{
    public partial class UnderstandingTheSwitchStatement : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            /*
          string result = "";
          int switchExpression = 0;

          switch (switchExpression)
          {

              case 0:
              case 1:
                  result += "Case 0 or 1 <br/>";
                  break;

              case 2:
                  result += "Case 2 <br/>";
                  goto case 1;

              case 7 - 4:
                  result += "Case 3<br />";
                  break;

              case 4:
                  result += "Case 4<br />";
                  throw new Exception();

              default:
                  result += "Default (Optional)<br/>";

                  break;
                  
        }
        */

            var hero = new CharacterX();
            hero.Name = "Harry Potter";
            hero.Type = CharacterTypeX.Wizard;

            string result = "";
            switch (hero.Type)
            {
                case CharacterTypeX.Wizard:
                    result += "Wizard";
                    break;
                case CharacterTypeX.Pokemon:
                    result += "Pokemon";
                    break;
                case CharacterTypeX.RoBeast:
                    result += "RoBeast";
                    break;
                case CharacterTypeX.HighWizard:
                    result += "HighWizard";
                    break;
                default:
                    break;
            }

            resultLabel.Text = result;
        }
    }

    public class CharacterX
    {
        public string Name { get; set; }
        public CharacterTypeX Type { get; set; }
    }

    public enum CharacterTypeX
    {
        Wizard,
        Pokemon,
        RoBeast,
        HighWizard
    }
}