using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DataWork
{
    public static class WorkWithContext
    {
        static WorkWithContext()
        {
            Models.Context context = new Models.Context();
            context.Respons.Add(new Models.Respons() { Name = "EEEE", Date = System.DateTime.Today, Row = "Egejhbf ekhbtve hjgberg rnb bghutbg erhtb gthrbg rthgb rthg rhgr thirsefjerhg srkths " });
            context.SaveChanges();
        }
        static public IEnumerable<Models.Respons> GetRespons()
        {
            Models.Context context = new Models.Context();
            return context.Respons.ToList();
        }
        static public void SendRespons(Models.Respons respons)
        {
            Models.Context context = new Models.Context();
            context.Respons.Add(respons);
            context.SaveChanges();
        }
        static public IEnumerable<Models.Form> GetForm()
        {
            Models.Context context = new Models.Context();
            return context.Forms.ToList();
        }
        static public void SendForm(Models.Form form)
        {
            Models.Context context = new Models.Context();
            context.Forms.Add(form);
            context.SaveChanges();
        }
    }
}