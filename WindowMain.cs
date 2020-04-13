using System;
using System.Windows.Forms;

namespace BudgetManager
{
    public partial class WindowMain : Form
    {
        //Creates a new instance of the Budgeter
        Budgeter budgeter = new Budgeter();

        public WindowMain()
        {
            InitializeComponent();
        }

        //Saves current budgeting list (ToDo)
        private void MenuSave(object sender, EventArgs e)
        {
            Console.WriteLine("Save");
        }

        //Loads a budgeting file (ToDo - Deciding file extension .txt/.json etc)
        private void MenuLoad(object sender, EventArgs e)
        {
            Console.WriteLine("Load");
        }

        //Checks if the user wishes to add a label with the budget item
        private void AddLabelCheck(object sender, EventArgs e)
        {
            if (checkBoxLabel.Checked) textBoxLabel.Enabled = checkBoxLabel.Checked;
            else textBoxLabel.Enabled = checkBoxLabel.Checked;
        }

        //Adds money into an instance of Budgeter.AddMoneyIn()
        private void AddMoneyIn(object sender, EventArgs e)
        {
            //If the numericUpDownMoneyIn value is more than 0
            if (numericUpDownMoneyIn.Value > 0)
            {
                //If the string is not null or white space and the textbox is enabled
                if (!String.IsNullOrWhiteSpace(textBoxLabel.Text) && textBoxLabel.Enabled)
                {
                    //The user wants to add a label

                    //Sets the textBoxLabel text to a shorter variable
                    string str = textBoxLabel.Text;

                    //Sets the numericUpDownMoneyIn value to a shorter variable
                    decimal money = numericUpDownMoneyIn.Value;

                    //Adds money into the budgeter instance via AddMoneyIn() - Taking a string & a decimal
                    budgeter.AddMoneyIn(str, money);

                    //Adds the item label and money to the listBoxBudgeting list
                    listBoxBudgeting.Items.Add(str + " - £" + money.ToString("N") + " +");

                    //Resets the textBoxLabel text to empty
                    textBoxLabel.Text = String.Empty;

                    //Resets the numericUpDownMoneyIn value to 0
                    numericUpDownMoneyIn.Value = 0;

                    //Updates the labels to show the money added
                    UpdateMoneyLabels();
                }
                else
                {
                    //The user doesn't want to add a label

                    //Sets the numericUpDownMoneyIn value to a shorter variable
                    decimal money = numericUpDownMoneyIn.Value;

                    //Adds money into the budgeter instance via AddMoneyIn() - Taking a string & a decimal
                    budgeter.AddMoneyIn("", money);

                    //Adds the money to the listBoxBudgeting list
                    listBoxBudgeting.Items.Add("£" + money.ToString("N") + " +");

                    //Resets the numericUpDownMoneyIn value to 0
                    numericUpDownMoneyIn.Value = 0;

                    //Updates the labels to show the money added
                    UpdateMoneyLabels();
                }
            }
        }

        //Adds money into an instance of Budgeter.AddMoneyOut()
        private void AddMoneyOut(object sender, EventArgs e)
        {
            //If the numericUpDownMoneyOut value is more than 0
            if (numericUpDownMoneyOut.Value > 0)
            {
                //If the string is not null or white space and the textbox is enabled
                if (!String.IsNullOrWhiteSpace(textBoxLabel.Text) && textBoxLabel.Enabled)
                {
                    //The user wants to add a label

                    //Sets the textBoxLabel text to a shorter variable
                    string str = textBoxLabel.Text;

                    //Sets the numericUpDownMoneyOut value to a shorter variable
                    decimal money = numericUpDownMoneyOut.Value;

                    //Adds money into the budgeter instance via AddMoneyOut() - Taking a string & a decimal
                    budgeter.AddMoneyOut(str, money);

                    //Adds the item label and money to the listBoxBudgeting list
                    listBoxBudgeting.Items.Add(str + " - £" + money.ToString("N") + " -");

                    //Resets the textBoxLabel text to empty
                    textBoxLabel.Text = String.Empty;

                    //Resets the numericUpDownMoneyOut value to 0
                    numericUpDownMoneyOut.Value = 0;

                    //Updates the labels to show the money added
                    UpdateMoneyLabels();
                }
                else
                {
                    //Sets the numericUpDownMoneyOut value to a shorter variable
                    decimal money = numericUpDownMoneyOut.Value;

                    //Adds money into the budgeter instance via AddMoneyOut() - Taking a string & a decimal
                    budgeter.AddMoneyOut("", money);

                    //Adds the item label and money to the listBoxBudgeting list
                    listBoxBudgeting.Items.Add("£" + money.ToString("N") + " -");

                    //Resets the numericUpDownMoneyOut value to 0
                    numericUpDownMoneyOut.Value = 0;

                    //Updates the labels to show the money added
                    UpdateMoneyLabels();
                }
            }
        }

        //Sorts the budgeting list
        private void SortList(object sender, EventArgs e)
        {
            //If the list contains more than 1 item (No point sorting one item)
            if (listBoxBudgeting.Items.Count > 1)
            {
                //Then sort the items
                listBoxBudgeting.Sorted = true;
            }
        }

        //Edits the selected item in the listBoxBudgeting list
        private void EditSelected(object sender, EventArgs e)
        {
            //Sets the listBoxBudgeting SelectedIndex to a shorter variable
            int selected = listBoxBudgeting.SelectedIndex;

            //If selected is more than -1, an Item is selected
            if (selected > -1)
            {
                //If the "Edit Selected" button is enabled, disable it and other relevant list buttons
                if (buttonEditSelected.Enabled)
                {
                    //Disables Sort/Edit/Delete && Clear buttons
                    buttonSortList.Enabled = false;
                    buttonEditSelected.Enabled = false;
                    buttonDeleteSelected.Enabled = false;
                    buttonClearList.Enabled = false;

                    //Enables && shows the "Edit Selected" tableLayoutPanel
                    tableLayoutPanelEditSelected.Enabled = true;
                    tableLayoutPanelEditSelected.Visible = true;

                    //Disables && hides the "Money In" tableLayoutPanel
                    tableLayoutPanelMoneyIn.Enabled = false;
                    tableLayoutPanelMoneyIn.Visible = false;

                    //Disables && hides the "Money Out" tableLayoutPanel
                    tableLayoutPanelMoneyOut.Enabled = false;
                    tableLayoutPanelMoneyOut.Visible = false;

                    //Sets the textBoxEditLabel text to the selected label item from the list
                    textBoxEditLabel.Text = budgeter.GetLabelList(selected);

                    //Sets the numericUpDownEditMoney value to the selected money item from the list
                    numericUpDownEditMoney.Value = budgeter.GetMoneyList(selected);
                }
                //Else "Edit Selected" button is disabled, use the "Cancel" button instead
                else
                {
                    //Enables Sort/Edit/Delete && Clear buttons
                    buttonSortList.Enabled = true;
                    buttonEditSelected.Enabled = true;
                    buttonDeleteSelected.Enabled = true;
                    buttonClearList.Enabled = true;

                    //Disables && hides the "Edit Selected" tableLayoutPanel
                    tableLayoutPanelEditSelected.Enabled = false;
                    tableLayoutPanelEditSelected.Visible = false;

                    //Enables && shows the "Money In" tableLayoutPanel
                    tableLayoutPanelMoneyIn.Enabled = true;
                    tableLayoutPanelMoneyIn.Visible = true;

                    //Enables && shows the "Money Out" tableLayoutPanel
                    tableLayoutPanelMoneyOut.Enabled = true;
                    tableLayoutPanelMoneyOut.Visible = true;

                    //Resets the textBoxEditLabel text to empty
                    textBoxEditLabel.Text = String.Empty;

                    //Resets the numericUpDownEditMoney value to 0
                    numericUpDownEditMoney.Value = 0;
                }
            }
        }

        //If the user clicks off the selected item then cancel editing
        private void CancelEdit(object sender, EventArgs e)
        {
            //Only if the buttonEditSelected is disabled && the user has an item selected
            if (!buttonEditSelected.Enabled && listBoxBudgeting.SelectedIndex > -1)
            {
                //Disables Sort/Edit/Delete && Clear buttons
                buttonSortList.Enabled = true;
                buttonEditSelected.Enabled = true;
                buttonDeleteSelected.Enabled = true;
                buttonClearList.Enabled = true;

                //Disables && hides the "Edit Selected" tableLayoutPanel
                tableLayoutPanelEditSelected.Enabled = false;
                tableLayoutPanelEditSelected.Visible = false;

                //Enables && shows the "Money In" tableLayoutPanel
                tableLayoutPanelMoneyIn.Enabled = true;
                tableLayoutPanelMoneyIn.Visible = true;

                //Enables && shows the "Money Out" tableLayoutPanel
                tableLayoutPanelMoneyOut.Enabled = true;
                tableLayoutPanelMoneyOut.Visible = true;
            }
        }

        //Updates the currently selected item in the listBoxBudgeting list if the user has clicked "Edit Selected"
        private void UpdateSelected(object sender, EventArgs e)
        {
            //Sets the listBoxBudgeting.SelectedIndex to a shorter variable
            int selected = listBoxBudgeting.SelectedIndex;

            //If selected is more than -1, an Item is selected
            if (selected > -1)
            {
                //If the item currently selected contains a "+" then we need to edit the selected money in
                if (listBoxBudgeting.SelectedItem.ToString().Contains("+"))
                {
                    //Sets the textBoxEditLabel text to a shorter variable
                    string str = textBoxEditLabel.Text;

                    //Sets the numericUpDownEditMoney value to a shorter variable
                    decimal money = numericUpDownEditMoney.Value;

                    //Updates the selected label in the budgeter instance using SetLabelList()
                    budgeter.SetLabelList(selected, str);

                    //Updates the selected money in the budgeter instance using SetMoneyInList()
                    budgeter.SetMoneyInList(selected, money);

                    //If the string is not null or white space then the user edited the label, edit both
                    if (!String.IsNullOrWhiteSpace(str)) listBoxBudgeting.Items[selected] = str + " - £" + money.ToString("N") + " +";

                    //Else the user hasn't edited the label, Just edit the money
                    else listBoxBudgeting.Items[selected] = "£" + money.ToString("N") + " +";

                    //Updates the labels to show the money added
                    UpdateMoneyLabels();
                }
                //Else if the currently selected item contains a "-" then we need to edit the selected money out
                else if (listBoxBudgeting.SelectedItem.ToString().Contains("-"))
                {
                    //Sets the textBoxEditLabel text to a shorter variable
                    string str = textBoxEditLabel.Text;

                    //Sets the numericUpDownEditMoney value to a shorter variable
                    decimal money = numericUpDownEditMoney.Value;

                    //Updates the selected label in the budgeter instance using SetLabelList()
                    budgeter.SetLabelList(selected, str);

                    //Updates the selected money in the budgeter instance using SetMoneyInList()
                    budgeter.SetMoneyOutList(selected, money);

                    //If the string is not null or white space then the user edited the label, edit both
                    if (!String.IsNullOrEmpty(str)) listBoxBudgeting.Items[selected] = str + " - £" + money.ToString("N") + " -";

                    //Else the user hasn't edited the label, Just edit the money
                    else listBoxBudgeting.Items[selected] = "£" + money.ToString("N") + " -";

                    //Updates the labels to show the money updated
                    UpdateMoneyLabels();
                }
            }
        }

        //Deletes the currently selected item in the listBoxBudgeting list
        private void DeleteSelected(object sender, EventArgs e)
        {
            //Sets the listBoxBudgeting.SelectedIndex to a shorter variable
            int selected = listBoxBudgeting.SelectedIndex;

            //If selected is more than -1, an Item is selected
            if (selected > -1)
            {
                //If the item currently selected contains a "+" then we need to delete the selected money in
                if (listBoxBudgeting.SelectedItem.ToString().Contains("+"))
                {
                    //Deletes the selected item from listBoxBudgeting list
                    listBoxBudgeting.Items.RemoveAt(selected);

                    //Deletes the selected Money in the budgeter instance using RemoveMoneyIn()
                    budgeter.RemoveMoneyIn(selected);

                    //Updates the labels to show the money added
                    UpdateMoneyLabels();
                }
                //Else if the currently selected item contains a "-" then we need to edit the selected money out
                else if (listBoxBudgeting.SelectedItem.ToString().Contains("-"))
                {
                    //Deletes the selected item from listBoxBudgeting list
                    listBoxBudgeting.Items.RemoveAt(selected);

                    //Deletes the selected Money in the budgeter instance using RemoveMoneyOut()
                    budgeter.RemoveMoneyOut(selected);

                    //Updates the labels to show the money deleted
                    UpdateMoneyLabels();
                }
            }

        }

        //Clears the whole budgeting list
        private void ClearList(object sender, EventArgs e)
        {
            //Only if the listBoxBudgeting list has an item
            if (listBoxBudgeting.Items.Count > 0)
            {
                //Resets the textBoxLabel text to empty
                textBoxLabel.Text = String.Empty;

                //Resets the numericUpDownMoneyIn value to 0
                numericUpDownMoneyIn.Value = 0;

                //Resets the numericUpDownMoneyOut value to 0
                numericUpDownMoneyOut.Value = 0;

                //Clears the listBoxBudgeting items
                listBoxBudgeting.Items.Clear();

                //Resets the budgeter instance
                budgeter.ResetBudgeter();

                //Updates the labels to show the money cleared
                UpdateMoneyLabels();
            }
        }

        //Used to update the labels when money is added/deducted
        private void UpdateMoneyLabels()
        {
            //Sets labelMoneyInTotal text to the money in total in the budgeter
            labelMoneyInTotal.Text = "£" + budgeter.GetMoneyIn().ToString("N");

            //Sets labelMoneyInTotal text to the money out total in the budgeter
            labelMoneyOutTotal.Text = "£" + budgeter.GetMoneyOut().ToString("N");

            //Sets labelMoneyInTotal text to the money overall total in the budgeter
            labelMoneyTotal.Text = "£" + budgeter.GetMoneyTotal().ToString("N");
        }

        //Closes the app
        private void CloseClick(object sender, EventArgs e)
        {
            //Bye Bye
            this.Close();
        }
    }
}
