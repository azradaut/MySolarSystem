using System;
using System.Collections.Generic;
using System.Linq;

namespace MySolarSystem.Data
{
    public class QuizManager
    {
        private List<Question> allQuestions;
        private Random rng;

        public QuizManager()
        {
            allQuestions = new List<Question>
            {
                new Question
                {
                    Text = "Can you name the planet in the image?",
                    Choices = new List<string> { "Neptune", "Jupiter", "Mercury", "Mars" },
                    CorrectAnswerIndex = 2,
                    ImageUrl = "mercury.svg"
                },

                new Question
                {
                    Text = "How long does it take for Mercury to complete one revolution around the sun?",
                    Choices = new List<string> { "59 Earth days", "88 Earth days", "117 Earth days", "180 Earth days" },
                    CorrectAnswerIndex = 1,
                    ImageUrl = "mercury.svg"
                },

                new Question
                {
                    Text = "How long does it take for Mercury to complete one full rotation?",
                    Choices = new List<string> { "24 Earth hours", "59 Earth days", "88 Earth days", "117 Earth days" },
                    CorrectAnswerIndex = 1,
                    ImageUrl = "mercury.svg"
                },

                new Question
                {
                    Text = "How often does the sun rise on Mercury?",
                    Choices = new List<string> { "Every 24 Earth hours", "Every 59 Earth hours", "Every 88 Earth hours", "Every 180 Earth hours" },
                    CorrectAnswerIndex = 3,
                    ImageUrl = "mercury.svg"
                },


                new Question
                {
                    Text = "Can you name the planet in the image?",
                    Choices = new List<string> { "Neptune", "Saturn", "Uranus", "Venus" },
                    CorrectAnswerIndex = 3,
                    ImageUrl = "venus.svg"
                },

                new Question
                {
                    Text = "How long does it take for Venus to complete one full rotation?",
                    Choices = new List<string> { "24 Earth hours", "117 Earth hours", "225 Earth hours", "243 Earth hours" },
                    CorrectAnswerIndex = 3,
                    ImageUrl = "venus.svg"
                },

                new Question
                {
                    Text = "How often does the Sun rise on Venus?",
                    Choices = new List<string> { "Every 117 Earth days", "Every 24 Earth hours", " Every 225 Earth days", " Every 243 Earth days" },
                    CorrectAnswerIndex = 0,
                    ImageUrl = "venus.svg"
                },

                new Question
                {
                    Text = "What percentage of Earth's surface is covered by water?",
                    Choices = new List<string> { "30%", "50%", "70%", "90%" },
                    CorrectAnswerIndex = 2,
                    ImageUrl = "earth.svg"
                },

                new Question
                {
                    Text = "What role does Earth's atmosphere play in protecting us from meteoroids?",
                    Choices = new List<string> { "It absorbs meteoroids into the atmosphere.",
                        "It reflects meteoroids back into space.",
                        "It slows down meteoroids, preventing them from reaching the surface.",
                        "It breaks up meteoroids before they can strike the surface." },
                    CorrectAnswerIndex = 3,
                    ImageUrl = "earth.svg"
                },

                new Question
                {
                    Text = "Which gases make up the majority of Earth's atmosphere?",
                    Choices = new List<string> { "Nitrogen and oxygen",
                        "Carbon dioxide and oxygen", 
                        "Nitrogen and carbon dioxide",
                        "Oxygen and helium" },
                    CorrectAnswerIndex = 0,
                    ImageUrl = "earth.svg"
                },

                new Question
                {
                    Text = "What role does Earth's atmosphere play in protecting us from meteoroids?",
                    Choices = new List<string> { "It absorbs meteoroids into the atmosphere.",
                        "It reflects meteoroids back into space.",
                        "It slows down meteoroids, preventing them from reaching the surface.",
                        "It breaks up meteoroids before they can strike the surface." },
                    CorrectAnswerIndex = 3,
                    ImageUrl = "earth.svg"
                },

                new Question
                {
                    Text = "Can you name the planet in the image?",
                    Choices = new List<string> { "Saturn", "Mercury", "Mars", "Venus" },
                    CorrectAnswerIndex = 2,
                    ImageUrl = "mars.svg"
                },

                new Question
                {
                    Text = "What is the nickname given to Mars due to its distinctive color?",
                    Choices = new List<string> { "The Blue Planet",
                        " The Green Planet",
                        "The Red Planet",
                        "The Yellow Planet" },
                    CorrectAnswerIndex = 2,
                    ImageUrl = "mars.svg"
                },

                new Question
                {
                  
                    Text = "What evidence suggests the existence of ancient floods on Mars?",
                    Choices = new List<string> { "Signs of liquid water in the ground",
                        "Martian hillsides covered in ice",
                        "Discovery of ancient riverbeds",
                        "Observation of frequent rainfall" },
                    CorrectAnswerIndex = 2,
                    ImageUrl = "mars.svg"
                },

                new Question
                {

                    Text = "What is the main focus of scientists studying Mars?",
                    Choices = new List<string> { "Exploring the possibility of past or present life",
                        "Analyzing the composition of its atmosphere",
                        "Investigating the presence of volcanic activity",
                        "Understanding its unique geology" },
                    CorrectAnswerIndex = 0,
                    ImageUrl = "mars.svg"
                },


                new Question
                {
                    Text = "Can you name the planet in the image?",
                    Choices = new List<string> { "Jupiter", "Saturn", "Uranus", "Venus" },
                    CorrectAnswerIndex = 0,
                    ImageUrl = "jupiter.svg"
                },

                 new Question
                {
                    Text = "What is the Great Red Spot on Jupiter?",
                    Choices = new List<string> { " A solid surface feature",
                        " A massive storm",
                        " A ring around the planet",
                        "A volcanic eruption" },
                    CorrectAnswerIndex = 1,
                    ImageUrl = "jupiter.svg"
                },

                  new Question
                {
                    Text = "Does Jupiter have a solid surface?",
                    Choices = new List<string> { "Yes, it has a solid surface similar to Earth's.",
                        " Yes, but it is covered by thick clouds.",
                        "No, it is a gas giant with no solid surface.",
                        "No, it is covered by swirling cloud stripes." },
                    CorrectAnswerIndex = 2,
                    ImageUrl = "jupiter.svg"
                },

                   new Question
                {
                    Text = "How long does it take for Jupiter to complete one rotation (day)?",
                    Choices = new List<string> { "24 Earth hours",
                        "10 Earth hours",
                        "11.8 Earth years",
                        "365 Earth days" },
                    CorrectAnswerIndex = 1,
                    ImageUrl = "jupiter.svg"
                },

                    new Question
                {
                    Text = "Which planets are the neighbors of Jupiter in our solar system?",
                    Choices = new List<string> { " Mercury and Venus",
                        "Earth and Mars",
                        "Saturn and Uranus",
                        "Mars and Saturn" },
                    CorrectAnswerIndex = 3,
                    ImageUrl = "jupiter.svg"
                },

                    new Question
                {
                    Text = "Can you name the planet in the image?",
                    Choices = new List<string> { "Neptune", "Saturn", "Uranus", "Venus" },
                    CorrectAnswerIndex = 1,
                    ImageUrl = "saturn.svg"
                },

                    new Question
                {
                    Text = "What are Saturn's rings primarily composed of?",
                    Choices = new List<string> { "Gold and silver",
                        "Ice and rock",
                        "Diamonds and gemstones",
                        "Gas and dust" },
                    CorrectAnswerIndex = 1,
                    ImageUrl = "saturn.svg"
                },

                    new Question
                {
                    Text = "How did Galileo Galilei initially interpret what he saw when observing Saturn?",
                    Choices = new List<string> { "He thought he was looking at three separate planets.",
                        "He believed it was a planet with unusual features.",
                        "He mistook the rings for moons orbiting Saturn.",
                        "He saw it as a giant gas cloud without distinct features." },
                    CorrectAnswerIndex = 0,
                    ImageUrl = "saturn.svg"
                },

                    new Question
                {
                    Text = "Which missions have contributed to our understanding of Saturn through close exploration?",
                    Choices = new List<string> { "Hubble and Kepler",
                        "Apollo and Gemini",
                        "Pioneer 11, Cassini, Voyager 1, and Voyager 2",
                        "Curiosity and Perseverance" },
                    CorrectAnswerIndex = 2,
                    ImageUrl = "saturn.svg"
                },

                    new Question
                {
                    Text = "Can you name the planet in the image?",
                    Choices = new List<string> { "Neptune",
                        "Saturn",
                        "Uranus",
                        "Venus" },
                    CorrectAnswerIndex = 2,
                    ImageUrl = "uranus.svg"
                },

                    new Question
                {
                    Text = "What gives Uranus its blue color?",
                    Choices = new List<string> { "Hydrogen and helium",
                        "Ammonia and methane",
                        "Water and ammonia",
                        "Methane and helium" },
                    CorrectAnswerIndex = 1,
                    ImageUrl = "uranus.svg"
                },

                    new Question
                {
                    Text = "What is the unique characteristic of Uranus's rotation?",
                    Choices = new List<string> { "It spins in the same direction as Earth.",
                        "It rotates faster than any other planet.",
                        "It rotates on its side.",
                        "It changes its rotation direction periodically." },
                    CorrectAnswerIndex = 2,
                    ImageUrl = "uranus.svg"
                },
                    new Question
                {
                    Text = "How long does a year on Uranus last compared to Earth?",
                    Choices = new List<string> { "It is the same as an Earth year.",
                        "It is half the duration of an Earth year.",
                        "It is twice the duration of an Earth year.",
                        "It is equivalent to 84 Earth years." },
                    CorrectAnswerIndex = 3,
                    ImageUrl = "uranus.svg"
                },
                    new Question
                {
                    Text = "Can you name the planet in the image?",
                    Choices = new List<string> { "Neptune",
                        "Saturn",
                        "Uranus",
                        "Venus" },
                    CorrectAnswerIndex = 0,
                    ImageUrl = "neptune.svg"
                },

                    new Question
                {
                    Text = "How many moons accompany Neptune?",
                    Choices = new List<string> { "10",
                        "12",
                        "14",
                        "16" },
                    CorrectAnswerIndex = 2,
                    ImageUrl = "neptune.svg"
                },

                    new Question
                {
                    Text = "Which spacecraft has visited Neptune?",
                    Choices = new List<string> { "Pioneer 11",
                        "Voyager 1",
                        "Voyager 2",
                        "Cassini" },
                    CorrectAnswerIndex = 2,
                    ImageUrl = "neptune.svg"
                },



            };

            rng = new Random();
        }

        public List<Question> GetRandomQuestions(int count)
        {
            List<Question> selectedQuestions = allQuestions.OrderBy(_ => rng.Next()).Take(count).ToList();
            return selectedQuestions;
        }
    }
}
