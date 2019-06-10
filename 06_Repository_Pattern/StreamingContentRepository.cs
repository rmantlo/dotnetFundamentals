using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Repository_Pattern
{
    public class StreamingContentRepository
    {
        //field
        private List<StreamingContent> _listOfContent = new List<StreamingContent>();

        public void AddContentToList(StreamingContent content)
        {
            _listOfContent.Add(content);
        }
        public List<StreamingContent> GetStreamingContentList()
        {
            return _listOfContent;
        }
        public StreamingContent GetContentByTitle(string title)
        {
            foreach (StreamingContent content in _listOfContent)
            {
                if (content.Title.ToLower() == title.ToLower())
                {
                    return content;
                }
            }
            return null;
        }
        public bool RemoveContentFromList(StreamingContent content)
        {
            int initialCount = _listOfContent.Count;
            _listOfContent.Remove(content);
            if (initialCount > _listOfContent.Count)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public void UpdateContentInList(string originalTitle, StreamingContent updatedContent)
        {
            StreamingContent oldContent = GetContentByTitle(originalTitle);
            oldContent.Title = updatedContent.Title;
            oldContent.Description = updatedContent.Description;
            oldContent.StarRating = updatedContent.StarRating;
            oldContent.RunTimeInMinutes = updatedContent.RunTimeInMinutes;
            oldContent.MaturityRating = updatedContent.MaturityRating;
            oldContent.IsFamilyFriendly = updatedContent.IsFamilyFriendly;
            oldContent.TypeOfGenre = updatedContent.TypeOfGenre;

            //or oldContent = updatedContent;

        }
    }
}
