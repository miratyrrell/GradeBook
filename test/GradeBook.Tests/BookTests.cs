using System;
using Xunit;

namespace GradeBook.Tests
{
    public class BookTests
    {
        [Fact]
        public void TestBook()
        {
            // arrange data section
            var book = new Book("test");
            book.AddGrade(89.1);
            book.AddGrade(90.5);
            book.AddGrade(77.3);

            // act data section

            //in this case ShowStatistics is doing too much. We need ot break down the method.
            var result = book.GetStatistics();

            // assert section - assert something about the value that was computed in act section
            Assert.Equal(85.6, result.Average, 1);
            Assert.Equal(90.5, result.High, 1);
            Assert.Equal(77.3, result.Low, 1);
        }
    }
}
