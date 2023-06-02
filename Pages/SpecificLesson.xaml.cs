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

            // Set the description for the lessonImage
            SemanticProperties.SetDescription(lessonImage, "Illustration of " + lessonName);

            // Set the heading level and text for the lessonHeading
            SemanticProperties.SetHeadingLevel(lessonHeading, SemanticHeadingLevel.Level1);
            lessonHeading.Text = lesson.Heading;

            // Set the description for the lessonparagraph
            SemanticProperties.SetDescription(lessonparagraph, lesson.Paragraph);

            // Set the source for the lessonImage and other UI updates
            lessonImage.Source = lesson.Image;
            lessonparagraph.Text = lesson.Paragraph;


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
