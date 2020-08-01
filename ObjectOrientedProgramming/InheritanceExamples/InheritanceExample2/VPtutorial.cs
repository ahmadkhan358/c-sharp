using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classes_and_inheritance
{
    class VPtutorial : Tutorial
    {
        public void renameTutorial(string rename)
        {
            tutorialName = rename;
        }

        public string getRenameTutorial()
        {
            string rename = getTutorial();

            return rename;
        }
    }
}
