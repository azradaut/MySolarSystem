using MySolarSystem.Data;

namespace MySolarSystem.Pages
{
    [QueryProperty(nameof(LessonName), "lessonName")]
    public partial class SpecificLesson : ContentPage
    {
        string lessonName;
        public string LessonName
        {
            get => lessonName;
            set
            {
                lessonName = value;

                UpdateLessonUI(lessonName);
            }
        }

        public SpecificLesson()
        {
            InitializeComponent();
        }

        void UpdateLessonUI(string lessonName)
        {
            Lesson lesson = FindLessonData(lessonName);

            Title = lesson.Heading;

            lessonImage.Source = lesson.Image;
            lessonHeading.Text = lesson.Heading;
            lessonparagraph1.Text = lesson.Paragraph1;
            lessonparagraph2.Text = lesson.Paragraph2;
            lessonparagraph3.Text = lesson.Paragraph3;
        }

        Lesson FindLessonData(string specificLessonName)
        {
            return specificLessonName switch
            {
                "solar_system" => LessonsData.SolarSystem,
                "mercury" => LessonsData.Mercury,
                "venus" => LessonsData.Venus,
                "earth" => LessonsData.Earth,
                "mars" => LessonsData.Mars,
                "jupiter" => LessonsData.Jupiter,
                "saturn" => LessonsData.Saturn,
                "uranus" => LessonsData.Uranus,
                "neptune" => LessonsData.Neptune,

                _ => throw new ArgumentException()
            };
        }
    }
}
