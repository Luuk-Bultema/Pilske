using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pilske
{
    class HapjeController
    {
        private DatabaseDataContext db;
        public HapjeController(DatabaseDataContext db)
        {
            this.db = db;
        }

        public void opslaanHapjes(String Hapje)
        {
            hapje deproduct = new hapje();
            deproduct.hapje1 = Hapje;


            //Wachtrij, wordt nog niet doorgevoerd naar de database
            db.hapjes.InsertOnSubmit(deproduct);
            //Daadwerkelijk doorvoeren naar de database
            db.SubmitChanges();

        }

        public void updateHapjes(hapje p, string sHapje)
        {

            p.hapje1 = sHapje;


            db.SubmitChanges();
        }

        public void deleteHapjes(hapje deproduct)
        {
            db.hapjes.DeleteOnSubmit(deproduct);
            db.SubmitChanges();
        }

        public List<hapje> geefAllehapjes()
        {
            return db.hapjes.ToList();
        }



    }
}
