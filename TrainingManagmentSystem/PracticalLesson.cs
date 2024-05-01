using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingManagmentSystem
{
    public class PracticalLesson : ILecturePractiacal
    {
        public string Description { get; set; }
        public string TaskCondition { get; }
        public string Solution { get; }

        public PracticalLesson(string description, string taskcondition, string solution)
        {
            Description = description;
            TaskCondition = taskcondition;
            Solution = solution;
        }
    }
}
