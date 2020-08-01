
namespace classes_and_inheritance
{
    class Tutorial
    {
        public int tutorialID;
        public string tutorialName;

        public void setTutorial(int tID, string tName)
        {
            tutorialID = tID;
            tutorialName = tName;
        }


        public string getTutorial()
        {
            return tutorialName;
        }
    }
}
