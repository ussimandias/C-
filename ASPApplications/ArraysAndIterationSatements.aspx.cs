using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASPApplications
{
    /*Indexes vs. Elements
     * Accessor vs. Stored Values
     * Indexes are zero based
     * 
     * Declaring Arrays
     * string[] myArray = new string[3]
     * 
     * Initialization on Declaration:
     * string[] myString = new string[5] { "a", "b", "c", "d", "e" };
     * 
     * Setting / Getting Values
     * sting[] myString = myArray[1] // Retrieves the second element
     * myArray[0] = myString; //Sets first element
     */

    public partial class DevSheet5 : System.Web.UI.Page
    {
        //Scope
        double[,] priceGrid;

        protected void Page_Load(object sender, EventArgs e)
        {
            //if (Page.IsPostBack)
            //    resultTextBox.Text = "";

            /*
             *Declaring Multidimentional Arrays
             */
            //double[,] priceGrid = new double[3, 3];

            //0 - Chicago
            //1- New York
            //2 - London


            priceGrid = new double[3, 3];

            priceGrid[0, 1] = 350.0;
            priceGrid[0, 2] = 750.0;
           
            priceGrid[1, 0] = 400.0; 
            priceGrid[1, 2] = 700.0;
          
            priceGrid[2, 0] = 800.0;
            priceGrid[2, 1] = 805.0;

            //multiresultTextBox.Text = priceGrid[1, 2].ToString();
          
            if (!Page.IsPostBack)
            {
                //Changing the Length of an Array - addHours exercise.
                double[] hours = new double[0];
                ViewState.Add("Hours", hours);

                //Challenge EpicSpies
                //TODO:
                //Declare the arrays
                int[] rigger = new int[0];
                string[] asset = new string[0];
                int[] actsPerformed = new int[0];

                //Challenge EpicSpies
                //TODO
                //Create enteries for ViewState
                ViewState.Add("Rigger", rigger);
                ViewState.Add("Asset", asset);
                ViewState.Add("ActsPerformed", actsPerformed);
            }

            //looping with the for interation statement
            /*
             * 
             * 
             * 
            for (int i = 0; i < 10; i++)
            {
                forloopResultLabel.Text += i.ToString() + "<br />";
            }
            
            is or equal too expression:
            for (int i = 5; i <= 15; i++)
            {
                forloopResultLabel.Text += i.ToString() + "<br />";
            }

            subtrating:
            for (int i = 15; i <= 5; i--)
            {
                forloopResultLabel.Text += i.ToString() + "<br />";
            }

            incrementing by 3:
            for (int i = 5; i <= 15; i+=3)
            {
                forloopResultLabel.Text += i.ToString() + "<br />";
            }         
             */

            // Wolverine fewest battles
            // Pheonix most battles

            string result = "";
            string[] names = new string[] { "Professor X", "Iceman", "Angel", "Beast", "Phoenix", "Cyclops", "Wolverine", "Storm", "Toad", "Sabre Tooth"};
            int[] numbers = new int[] { 7, 9, 12, 15, 17, 13, 2, 6, 8, 13 };

            //Create a variable  each for holding the largest and smallest index value
            int largestNumberIndex = 0;
            int smallestNumberIndex = 0;

            for (int i = 0; i < names.Length; i++)
            {
                // is this the largest count so far
                if (numbers[i] > numbers[largestNumberIndex] )
                {
                    largestNumberIndex = i;
                }

                // is this the smallest count so far
                if (numbers[i] < numbers[smallestNumberIndex])
                {
                    smallestNumberIndex = i;
                }
          
            }

            result = string.Format("Most battles belongs to: {0} (Value: {1})<br /> ", names[largestNumberIndex], numbers[largestNumberIndex]);
            result += string.Format("Least battles belongs to: {0} (Value: {1})", names[smallestNumberIndex], numbers[smallestNumberIndex]);

            //TODO:
            /*Sort, Reverse In Alphabetical Order.
            Array.Sort(names);
            Array.Reverse(names)

            for (int i = 0; i < names.Length; i++)
            {
                //Reference each value in the array with i. (i.e names[i])
                result += names[i] + "<br />";
            }
            forloopResultLabel.Text = result;
            */

            //for (int i = 0; i < names.Length; i++)
            //{
            //    if (names[i] == "Professor X")
            //    {
            //        result = string.Format("{0} is at index {1} in the list", names[i], i);
            //        break;
            //    }

            //}

            //***foreach loop****
            //foreach (var mutant in names)
            //{
            //    result += mutant + "<br />";
            //}

            forloopResultLabel.Text = result;

            //Random random = new Random();
            //random.Next(1,100); //returns a value between 1 and 100;

            /*If someExpression is already false this will never execute
             * while(someExpression)
             * {
             * //code that would affect whether some express is true
             * }
             */

            /*if someExpresion is already fales, this will run AT LEAST ONCE
             do{
             //code that wiould affect whether some expression is true or false
             }
             while(someExpression)
             */

        }

        protected void addButton_Click(object sender, EventArgs e)
        {
            /*
             * string[] myString = new string[5];
            myString[0] = TextBox1.Text;
            myString[1] = TextBox2.Text;
            myString[2] = TextBox3.Text;
            myString[3] = TextBox4.Text;
            myString[4] = TextBox5.Text;
             */

            //resultTextBox.Text = myString[2];
            //resultTextBox.Text = myString.Length.ToString();

            //Initialization on Declaration:
            string[] myString = new string[5] { "a", "b", "c", "d", "e" };

            ViewState.Add("MyStringArray", myString);
            resultTextBox.Text = "Values add ... ";


            //string value = ViewState["MyStringArray"].ToString();

        }

        protected void retrieveButton_Click(object sender, EventArgs e)
        {
            //passing an array to a viewstate
            string[] values = (string[])ViewState["MyStringArray"];

            TextBox1.Text = values[0];
            TextBox2.Text = values[1];
            TextBox3.Text = values[2];
            TextBox4.Text = values[3];
            TextBox5.Text = values[4];

            resultTextBox.Text = "values retrieved...";
        }

        protected void multidimentionButton_Click(object sender, EventArgs e)
        {
            //Retrieve the value of pricegrid
            int fromCity;

            if (chicagoRadioButton.Checked)
            {
                fromCity = 0;
            }
            else if (newYorkRadioButton.Checked)
            {
                fromCity = 1;
            }
            else { fromCity = 2; }


            int toCity;
            if (chicagoRadioButton2.Checked)
            {
                toCity = 0;
            }
            else if (newYorkRadioButton2.Checked)
            {
                toCity = 1;
            }
            else { toCity = 2; }

            if (fromCity == toCity) 
            {
                multiresultTextBox.Text = "";
                return;
            }

            multiresultTextBox.Text = "Total Price: " + priceGrid[fromCity, toCity].ToString();

        }

        protected void addhoursButton_Click(object sender, EventArgs e)
        {
            //Changing the Length of an Array - addHours exercise.
           

            double[] hours = (double[])ViewState["Hours"];

            /*
            * Arrays are Immutable - cannot be changed in memory.
            * However .NET Famework provides helper methods to 
            * resize an array... creates a new array and copies 
            * the old values into it.
            */
            Array.Resize(ref hours, hours.Length + 1);

            // Get the highest index:
            // 0 = dimension we want to retrieve the upper boundary for
            int newestItem = hours.GetUpperBound(0);

            hours[newestItem] = double.Parse(hoursworkedTextBox.Text);

            ViewState["Hours"] = hours;

            //Arrays have other helper methods
            /*
             * myArray.Sum()
             * myArray.Max()
             * myArray.Min()
             * myArray.Average()
             * myArray.Sort()
             * myArray.Reverse()
             */
            addHoursResultLabel.Text = String.Format("Total Hours: {0}<br />Most Hours: {1}<br />Least Hours: {2}<br />Average Hours {3:N2}", 
                hours.Sum()
                ,hours.Max()
                ,hours.Min()
                ,hours.Average());
        }

        protected void addAssetButton_Click(object sender, EventArgs e)
        {
            //Challenge EpicSpies -
            //TODO:
            //Retrieve values from ViewState and "CAST" the Arrays values to the appropriate type
            int[] rigger = (int[])ViewState["Rigger"];
            string[] asset = (string[])ViewState["Asset"];
            int[] actsPerformed = (int[])ViewState["ActsPerformed"];

            int newLength = asset.Length + 1;

            //TODO:
            //Resize each of the Arrays
            Array.Resize(ref rigger, newLength);
            Array.Resize(ref asset, newLength);
            Array.Resize(ref actsPerformed, newLength);

            //TODO: 
            //Take the values from the TextBoxes and put them into the newly sized Arrays at the highest index
            int newestIndex = asset.GetUpperBound(0);

            asset[newestIndex] = assetNameTextBox.Text;
            rigger[newestIndex] = int.Parse(riggedTextBox.Text);
            actsPerformed[newestIndex] = int.Parse(actsPerformedTextBox.Text);

            //TODO:
            //Save the values back in the ViewState
            ViewState["Rigger"] = rigger;
            ViewState["Asset"] = asset;
            ViewState["ActsPerformed"] = actsPerformed;

            //TODO:
            //Display Info
            assetResultLabel.Text = String.Format("Total Elections Rigged: {0} <br />Average Acts of Subterfuge per Asset: {1:N2}<br />(Last Asset you Added: {2})",
                rigger.Sum()
                , actsPerformed.Average()
                , asset[newestIndex]);

            //TODO:
            //Clear out text boxes for the next date entry for the next section
            assetNameTextBox.Text = "";
            riggedTextBox.Text = "";
            actsPerformedTextBox.Text = "";

        }

        protected void nestedAddButton_Click(object sender, EventArgs e)
        {
            //Code Blocks and Nested Statements
            /*
            if (CheckBox1.Checked)
            {
                if (CheckBox2.Checked)
                {
                    if (CheckBox3.Checked)
                    {
                        nestedResultTextBox.Text = "They are all checked!";
                    }
                }
            }
             */

            /*
             if (!CheckBox1.Checked) return;
            if (!CheckBox2.Checked) return;
            if (!CheckBox3.Checked) return;
            nestedResultTextBox.Text = "They are all checked!";                          
             */

            //if (CheckBox1.Checked &&
            //    CheckBox2.Checked &&
            //    CheckBox3.Checked)
            //{
            //    nestedResultTextBox.Text = "They are all checked!";
            //}

            int[] myArray = new int[] { 1, 3, 6, 2, 7, 5, 3, 8, 5 };
            //myArray[0] = 1;
            //myArray[1] = 2;
            //myArray[2] = 3;
            int i = myArray.Length - 1;

            //for (int i = myArray.Length;  i > 0; i-- )           
            //while(true)
            do
            {
                //nestedResultTextBox.Text = "<br/>" + myArray[i];
                //if (myArray[i++] > 6)
                //    break;    
                nestedResultTextBox.Text += myArray[i--].ToString();
            } while (myArray[myArray[i]] != 2);
            //nestedResultTextBox.Text = i.ToString();
        }
       
    }
}