using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingManagmentSystem
{
    public class Lecture : ILecturePractiacal
    {
        public string Description { get; set; }
        public string Topic { get; }

        public Lecture(string description, string topic)
        {
            Description = description;
            Topic = topic;
        }
    }
}
