using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StoryTeller.Models
{
    public interface TopicRepository
    {
        IEnumerable<Topic> GetAllTopic(); 
    }
}
