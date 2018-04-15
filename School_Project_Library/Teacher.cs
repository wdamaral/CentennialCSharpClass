using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    [Serializable]
    public class Teacher : Person
    {
        public List<Section> Sections { get; set; }

        public Teacher(string name, DateTime dOB) : base(name, dOB)
        {
            Sections = new List<Section>();
        }

        public string SectionsInfo()
        {
            string info = "";
            foreach (Section section in Sections)
            {
                info += String.Format("\t{0}\n", section.Name);
            }
            return info;
        }
    }
}
