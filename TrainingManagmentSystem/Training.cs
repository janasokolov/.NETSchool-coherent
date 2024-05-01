using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingManagmentSystem
{
    public class Training : ICloneable
    {
        private ILecturePractiacal[] lecturePracticals;
        private int count;
        public int Count { get { return count; } }

        public Training(int capacity)
        {
            lecturePracticals = new ILecturePractiacal[capacity];
            count = 0;
        }

        public void Add(ILecturePractiacal lecturePractiacal)
        {
            if (count < lecturePracticals.Length)
            {
                lecturePracticals[count] = lecturePractiacal;
                count++;
            }
            else
            {
                Console.Write("Training is full");
            }
        }

        public bool isPractical()
        {
            foreach (var lecturePractical in lecturePracticals)
            {
                if (lecturePractical is PracticalLesson)
                    return true;
            }
            return false;
        }
        public object Clone()
        {
            Training training = new Training(lecturePracticals.Length);
            for (int i = 0; i < count; i++)
            {
                if (lecturePracticals[i] is Lecture)
                {
                    training.Add(new Lecture((lecturePracticals[i] as Lecture).Description, (lecturePracticals[i] as Lecture).Topic));
                }
                else if (lecturePracticals[i] is PracticalLesson)
                {
                    training.Add(new PracticalLesson((lecturePracticals[i] as PracticalLesson).Description, (lecturePracticals[i] as PracticalLesson).TaskCondition, (lecturePracticals[i] as PracticalLesson).Solution));
                }

            }
            return training;
        }
    }
}
