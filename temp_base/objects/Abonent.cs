using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace temp_base.objects
{
    public class Abonent
    {
        private int id;
        private string name;
        private int REP;
        private DateTime date;
        private double sum_amouth;
        private int money_fold;
        private string adress;

        public Abonent(int id, string name, int REP, DateTime date, double sum_amouth, int money_fold, string adress)
        {
            this.id = id;
            this.name = name;
            this.REP = REP;
            this.date = date;
            this.sum_amouth = sum_amouth;
            this.money_fold = money_fold;
            this.adress = adress;
        }
        public string GetId { get { return Convert.ToString(id); } }
        public string GetName { get { return name; } }
        public string GetREP { get { return Convert.ToString(REP); } }
        public string GetDate { get { return Convert.ToString(date); } }
        public string GetSumAmouth { get { return Convert.ToString(sum_amouth); } }
        public string GetMoneyFold { get { return Convert.ToString(money_fold); } }
        public string GetAdress { get { return adress; } }
    }
}
