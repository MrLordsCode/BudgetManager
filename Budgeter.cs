using System.Collections.Generic;
using System.Linq;

namespace BudgetManager
{
    class Budgeter
    {
        //List to store each label (If used) in a budgeting list
        private List<string> labelList = new List<string>();

        //List to store each money added in a budgeting list
        private List<decimal> moneyList = new List<decimal>();

        //Decimal for the total money in
        private decimal moneyIn = 0;

        //Decimal for the total money out
        private decimal moneyOut = 0;

        //Decimal for the total money overall
        private decimal moneyTotal = 0;

        //Returns the total money in
        public decimal GetMoneyIn()
        {
            return moneyIn;
        }

        //Returns the total money out
        public decimal GetMoneyOut()
        {
            return moneyOut;
        }

        //Returns the total money overall
        public decimal GetMoneyTotal()
        {
            return moneyTotal;
        }

        //Used to add money to moneyIn and moneyTotal and add a label and money into the budgeting list
        public void AddMoneyIn(string str, decimal m)
        {
            labelList.Add(str);
            moneyList.Add(m);
            moneyIn += m;
            moneyTotal += m;
        }

        //Used to remove label and money from the budgeting list
        public void RemoveMoneyIn(int i)
        {
            moneyIn -= moneyList.ElementAt(i);
            moneyTotal -= moneyList.ElementAt(i);
            if (i > -1 && i < labelList.Count) labelList.RemoveAt(i);
            if (i > -1 && i < moneyList.Count) moneyList.RemoveAt(i);
        }

        //Used to add money to moneyOut and deduct from moneyTotal and add a label and money into the budgeting list
        public void AddMoneyOut(string str, decimal m)
        {
            labelList.Add(str);
            moneyList.Add(m);
            moneyOut += m;
            moneyTotal -= m;
        }

        //used to remove label and money from the budgeting list
        public void RemoveMoneyOut(int i)
        {
            moneyOut -= moneyList.ElementAt(i);
            moneyTotal += moneyList.ElementAt(i);
            if (i > -1 && i < labelList.Count) labelList.RemoveAt(i);
            if (i > -1 && i < moneyList.Count) moneyList.RemoveAt(i);
        }

        //Returns the current label matching the paramater else returns nothing
        public string GetLabelList(int i)
        {
            if (i > -1 && i < labelList.Count) return labelList.ElementAt(i).ToString();
            else return "";
        }

        //Sets the current label matching the paramaters
        public void SetLabelList(int i, string str)
        {
            if(i > -1 && i < labelList.Count) labelList[i] = str;
        }

        //Returns the current money matching the paramater else returns nothing
        public decimal GetMoneyList(int i)
        {
            if (i > -1 && i < moneyList.Count) return moneyList.ElementAt(i);
            else return 0;
        }

        //Sets the current money in matching the paramaters
        public void SetMoneyInList(int i, decimal d)
        {
            moneyIn -= moneyList[i];
            moneyTotal -= moneyList[i];
            moneyList[i] = d;
            moneyIn += moneyList[i];
            moneyTotal += moneyList[i];
        }

        //Sets the current money out matching the paramaters
        public void SetMoneyOutList(int i, decimal d)
        {
            moneyOut -= moneyList[i];
            moneyTotal += moneyList[i];
            moneyList[i] = d;
            moneyOut += moneyList[i];
            moneyTotal -= moneyList[i];
        }

        //Resets the whole budgeter class
        public void ResetBudgeter()
        {
            moneyIn = 0;
            moneyOut = 0;
            moneyTotal = 0;
            labelList.Clear();
            moneyList.Clear();
        }
    }
}
