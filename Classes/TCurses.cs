using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    public partial class TeachersCurses
    {
        public string cur
        {
            get
            {
                if ((Curse.EndDate > new DateTime()) || (Curse.EndDate > new DateTime().AddDays(-1)))
                {
                    return "true";

                }
                else
                {
                    return "false";
                }
            }
        }
    }
}
