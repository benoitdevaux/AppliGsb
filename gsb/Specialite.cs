using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace gsb
{
    class Specialite
    {
        string id, specialite;

        public Specialite(string id, string specialite)
        {
            this.id = id;
            this.specialite = specialite;
        }

        public string getId()
        {
            return this.id;
        }

        public void setId(string unId)
        {
            this.id = unId;
        }

        public string getSpecialite()
        {
            return this.specialite;
        }

        public void setSpecialite(string uneSpe)
        {
            this.specialite = uneSpe;
        }
    }
}
