

namespace TrainingSystemTestsProject;

[TestClass]
public class TrainingSystemTests
{
    [TestMethod]
    public void AddComponent_Test()
    {
        Training training = new Training(2);
        ILecturePractical lecture = new Lecture("Description", "Topic");

    }
}