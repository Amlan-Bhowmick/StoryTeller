using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StoryTeller.Models
{
    public class MockTopicRepository: TopicRepository
    {
        private List<Topic> _TopicList;
        public MockTopicRepository()
        {
            _TopicList = new List<Topic>()
            {
                new Topic() {topic = "Four Friends" , imagePath = "/Images/fourFriens.jpg" , story = "Once upon a time in a city,There lived two frieds.They used to quarrel at every "},
            new Topic() { topic = "Morning walk", imagePath = "/Images/Race.jpg", story = "This is a story of two friends. Going in morning walk together." }
            };
        }

        public IEnumerable<Topic> GetAllTopic()
        {
            return _TopicList;
        }
    }
}
