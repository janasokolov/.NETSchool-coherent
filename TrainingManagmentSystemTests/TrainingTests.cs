using TrainingManagmentSystem;
namespace TrainingManagmentSystemTests
{
    [TestClass]
    public class TrainingTests
    {
        [TestMethod]
        public void AddComponent_Test()
        {
            // Arrange
            Training training = new Training(2);
            ILecturePractiacal lecture = new Lecture("Description", "Topic");
            ILecturePractiacal practicalLesson = new PracticalLesson("Description", "TaskCondition", "Solution");

            // Act
            training.Add(lecture);
            training.Add(practicalLesson);

            // Assert
            Assert.AreEqual(2, training.Count);
        }

        [TestMethod]
        public void AddComponents_Test_Negative()
        {
            Training training = new Training(1);
            ILecturePractiacal lecture = new Lecture("Description", "Topic");
            ILecturePractiacal practicalLesson = new PracticalLesson("Description", "TaskCondition", "Solution");

            training.Add(lecture);
            training.Add(practicalLesson);

            Assert.AreEqual("Training is full", "Training is full");
        }

        [TestMethod]
        public void isPractical_Test()
        {
            Training training = new Training(2);
            ILecturePractiacal lecture = new Lecture("Description", "Topic");
            ILecturePractiacal practicalLesson = new PracticalLesson("Description", "TaskCondition", "Solution");

            training.Add(lecture);
            training.Add(practicalLesson);

            Assert.AreEqual(true, training.isPractical());
        }

        [TestMethod]
        public void isPractical_Test_Negative()
        {
            Training training = new Training(2);
            ILecturePractiacal lecture = new Lecture("Description", "Topic");
            ILecturePractiacal lecture2 = new Lecture("Description", "Topic");

            training.Add(lecture);
            training.Add(lecture2);

            Assert.AreEqual(false, training.isPractical());
        }

        [TestMethod]
        public void Clone_Test()
        {
            Training training = new Training(2);
            ILecturePractiacal lecture = new Lecture("Description", "Topic");
            ILecturePractiacal practicalLesson = new PracticalLesson("Description", "TaskCondition", "Solution");

            training.Add(lecture);
            training.Add(practicalLesson);

            Training training2 = (Training)training.Clone();

            Assert.AreEqual(training.Count, training2.Count);
        }
    }
}