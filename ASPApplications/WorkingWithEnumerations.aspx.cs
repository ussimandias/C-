using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASPApplications
{
    public partial class WorkingWithEnumerations : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            /*
              var metaCreature = new Character();
            metaCreature.Name = "Zygard";
            metaCreature.Type = CharacterType.Pokemon;

            if (metaCreature.Type == CharacterType.Pokemon)
            {
                resultLabel.Text = "Our hero is a pokemon!!";
            }
             */

        }   
        protected void Button1_Click1(object sender, EventArgs e)
        {
            var metaCreature = new CharacterE();
            metaCreature.Name = heroNameTextBox.Text;

            CharacterType selection;
            if (Enum.TryParse(heroTypeDropDownList.SelectedValue, out selection))
            {
                metaCreature.Type = selection;
            }

            if (metaCreature.Type == CharacterType.Pokemon)
            {
                resultLabel.Text = "You selected a pokemon!!";
            }
        }
    }

    public class CharacterE
    {
        public string Name { get; set; }
        public CharacterType Type { get; set; }
    }

    public enum CharacterType
    {
        Wizard,
        Pokemon,
        RoBeast,
        HighWizard
    }
}