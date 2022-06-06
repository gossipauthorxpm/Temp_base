using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace temp_base.objects
{
    public class Abonent
    {
        int id;
        string name;
        int REP;
        DateTime date;
        double sum_amouth;
        int money_fold;

        public Abonent(int id, string name, int REP, DateTime date, double sum_amouth, int money_fold)
        {
            this.id = id;
            this.name = name;
            this.REP = REP;
            this.date = date;
            this.sum_amouth = sum_amouth;
            this.money_fold = money_fold;
        }
    }
}
