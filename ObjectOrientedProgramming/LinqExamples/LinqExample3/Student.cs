namespace Linq2
{
    class Student
    {
        public string Name { get; set; }
        public string FName { get; set; }
        public int Standard { get; set; }
        public int RollNo { get; set; }
        public int StudentResultID { get; set; }
        public Student(string name = "No name", string fname = "No father name",
            int standard = 0, int rollno = 0, int studentresultid = 0)
        {
            Name = name;
            FName = fname;
            Standard = standard;
            RollNo = rollno;
            StudentResultID = studentresultid;
        }
        public override string ToString()
        {
            return string.Format($"{Name} has roll number {RollNo} and studies in {Standard} standard");
        }
    }
}