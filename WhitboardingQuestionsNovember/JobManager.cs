using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhitboardingQuestionsNovember
{
    public class Jobs
    {
        private string jobPriority;
        private string jobName;
        public Jobs(string priority, string name)
        {
            jobPriority = priority;
            jobName = name;
        }
    }
    public class JobContainer
    {
        public Stack<Jobs> jobStack = new Stack<Jobs>();
        public Queue<Jobs> jobQueue = new Queue<Jobs>();
    }

    public class JobManager
    {
       
    }
}
