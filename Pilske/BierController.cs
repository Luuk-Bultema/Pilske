using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pilske
{
    class BierController
    {
        private DatabaseDataContext db;
        public BierController(DatabaseDataContext db)
        {
            this.db = db;
        }

        public void opslaanBieren(String Bier)
        {
            bieren deproduct = new bieren();
            deproduct.bier = Bier;
          

            //Wachtrij, wordt nog niet doorgevoerd naar de database
            db.bierens.InsertOnSubmit(deproduct);
            //Daadwerkelijk doorvoeren naar de database
            db.SubmitChanges();

        }

        public void updateBieren(bieren p, string sBier)
        {

            p.bier = sBier;


            db.SubmitChanges();
        }

        public void deleteBieren(bieren deproduct)
        {
            db.bierens.DeleteOnSubmit(deproduct);
            db.SubmitChanges();
        }

        public List<bieren> geefAllebieren()
        {
            return db.bierens.ToList();
        }


    }
}
