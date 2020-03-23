using System;

namespace AssemblyOne
{
    public class AssemblyOneClassI
    {
        protected internal int ID = 101;

    }
    public class AssemblyOneClassII : AssemblyOneClassI
    {
        public void SampleMethode()
        {
            AssemblyOneClassI AI = new AssemblyOneClassI();
            Console.WriteLine(AI.ID);
        }
    }
}
