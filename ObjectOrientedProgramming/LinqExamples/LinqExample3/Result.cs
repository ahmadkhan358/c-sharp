namespace Linq2
{
    class Result
    {
        public double Physics { get; set; }
        public double Math { get; set; }
        public double Chemistry { get; set; }
        public int ResultID { get; set; }
        public Result(double physics = 0.0,double math=0.0,double chemistry=0.0,int resultid = 0)
        {
            Physics = physics;
            Math = math;
            Chemistry = chemistry;
            ResultID = resultid;
        }
    }
}
