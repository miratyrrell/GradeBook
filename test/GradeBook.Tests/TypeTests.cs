using System;
using Xunit;

namespace GradeBook.Tests
{
    public class TypeTests
    {

        [Fact]
        public void ValueTypesAlsoPassByValue()
        {
            var x = GetInt();
            SetInt(x);

            Assert.Equal(3, x);
        }

        private void SetInt(int z)
        {
            z = 42;
        }

        private int GetInt()
        {
            return 3;
        }

        [Fact]
        public void CSharpCanPassByRef()
        {
            var book1 = GetBook("Book 1");
            GetBookSetName(ref book1, "New Name");

            Assert.Equal("New Name", book1.Name);
        }
        private void GetBookSetName(ref Book book, string name)
        {
            book = new Book(name);
        }


        [Fact]
        public void CSharpIsPassByValue()
        {
            var book1 = GetBook("Book 1");
            GetBookSetName(book1, "New Name");

            Assert.Equal("Book 1", book1.Name);
        }
        private void GetBookSetName(Book book, string name)
        {
            book = new Book(name);
            book.Name = name;
        }

        [Fact]
        public void GetBookReturnDifferentObjects()
        {
            // arrange data section
            var book1 = GetBook("Book 1");
            var book2 = GetBook("Book 2");

            // act data section
            var result = book1.Name;
            var result2 = book2.Name;

            // assert section - assert something about the value that was computed in act section
            Assert.Equal("Book 1", result);
            Assert.Equal("Book 2", result2);
            Assert.NotSame(result, result2);
        }

        [Fact]
        public void TwoVarsCanReferenceSameObject()
        {
            // arrange data section
            var book1 = GetBook("Book 1");
            var book2 = book1;

            // act data section
            var result = book1.Name;
            var result2 = book2.Name;

            // assert section - assert something about the value that was computed in act section
            Assert.Same(result, result2);
            Assert.True(Object.ReferenceEquals(result, result2));
        }

        Book GetBook(string name)
        {
            return new Book(name);
        }
    }
}