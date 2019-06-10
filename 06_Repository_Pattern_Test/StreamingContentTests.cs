using System;
using _06_Repository_Pattern;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _06_Repository_Pattern_Test
{
    [TestClass]
    public class StreamingContentTests
    {
        private StreamingContentRepository _contentRepo;
        private StreamingContent _content;

        [TestInitialize] //runs before each test, everytime
        public void Arrange()
        {
            _contentRepo = new StreamingContentRepository();
            _content = new StreamingContent("Toy Story", GenreType.WildWest, "Living Toys AHHHH.", 104d, 4.9d, "PG", true);
        }
        [TestMethod]
        public void StreamingContentPOCOTests()
        {
            StreamingContent content = new StreamingContent("Avatar", GenreType.WildWest, "Little Boy with power over the four elements must unite the world.", 124d, 4.9d, "PG", true);
            Assert.AreEqual(GenreType.WildWest, content.TypeOfGenre);
            Assert.AreEqual("PG", content.MaturityRating);
        }
        [TestMethod]
        public void StreamingContentRepositoryAddToList()
        {
            //arrange
            //Arrange();
            //act
            _contentRepo.AddContentToList(_content);

            int expected = 1;
            int actual = _contentRepo.GetStreamingContentList().Count;
            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
         public void StreamingContentSearchByTitle()
        {
            //arrange
            //Arrange(); auto called before test run
            _contentRepo.AddContentToList(_content);
            //act

            StreamingContent resultContent = _contentRepo.GetContentByTitle("Toy Story");
            //assert
            Assert.AreEqual(_content, resultContent);
        }
        [TestMethod]
        public void RemoveFromListTest()
        {
            //arrange
            //Arrange();
            _contentRepo.AddContentToList(_content);
            //act

            bool wasRemoved = _contentRepo.RemoveContentFromList(_content);
            //assert
            Assert.IsTrue(wasRemoved);

        }
        [TestMethod]
        public void UpdateContentTest()
        {
            //arrange
            //StreamingContentRepository contentRepo = new StreamingContentRepository();
            //StreamingContent content = new StreamingContent("Toy Story", GenreType.WildWest, "Living Toys AHHHH.", 104d, 4.9d, "PG", true);
            //act
            _contentRepo.AddContentToList(_content);
            StreamingContent newContent = new StreamingContent("Toy Story 2", GenreType.Horror, "Some new description", 444, 4, "R",true);
            _contentRepo.UpdateContentInList("Toy Story", newContent);

            StreamingContent updatedContent = _contentRepo.GetContentByTitle("Toy Story 2");
            //assert
            //Assert.AreEqual(newContent, updatedContent); //does not work, areEqual not for comparing objects well
            //Assert.AreSame(newContent, updatedContent); //still looking for the same object, but these are diff obj but same values
            Assert.AreEqual(newContent.Description, updatedContent.Description);
        }
    }
}
