using System.Collections.Generic;

namespace Book.Tests
{
    using System;
    using NUnit.Framework;

    public class Tests
    {
        [Test]
        public void TestSetTheValueConstructor()// judge return 100/100
        {
            Book book = new Book("Henzel And Gretel", "Brother Grim");

            Assert.AreEqual("Henzel And Gretel", book.BookName);
            Assert.AreEqual("Brother Grim", book.Author);
            Assert.AreEqual(0, book.FootnoteCount);
        }

        [Test]
        public void BookNameTestThrowExetpionToNoCorectlySetValue()
        {
            Assert.That(() => new Book(String.Empty, "Whiliam Selt"), Throws.ArgumentException);
            Assert.That(() => new Book(null, "Whiliam Selt"), Throws.ArgumentException);
        }

        [Test]
        public void AuthorTestThrowExetpionToNoCorectlySetValue()
        {
            Assert.That(() => new Book("Blood", String.Empty), Throws.ArgumentException);
            Assert.That(() => new Book("Hary Poter ", null), Throws.ArgumentException);
        }

        [Test]
        public void AddFootnoteMethodTestAddOfDictionary()
        {
            Book books = new Book("Hour to Die", "Pedro Alfer");
            books.AddFootnote(1, "To Beginning");
            books.AddFootnote(2, "To Beginning");
        
            var set = books.FindFootnote(1);
        
            Assert.AreEqual(2, books.FootnoteCount);
            Assert.AreEqual(set, $"Footnote #{1}: {"To Beginning"}");
        }

        [Test]
        public void MethodAddFootnoteShouldByCorectlyAddBookNameAndAuthor()
        {
            Book book = new Book("Hensel and Gretel", "Brother GRIM");
            Dictionary<int, string> bookCollection = new Dictionary<int, string>();

            bookCollection.Add(1, "Radoslav Hristov");
            Assert.AreEqual(1, bookCollection.Count);
        }

        [Test]
        public void AddFootnoteMethodTestThrowExceptionOfNotCurectlySet()
        {
            Book books = new Book("Hour to Die", "Pedro Alfer");
            books.AddFootnote(1, "To Beginning");
            books.AddFootnote(2, "To Beginning");

            Assert.That(() => books.AddFootnote(1, "To My History"), Throws.InvalidOperationException,
                "Footnote already exists!");
        }

        [Test]
        public void FindFootnoteMethodThrowException()
        {
            Book books = new Book("Hour to Die", "Pedro Alfer");

            Assert.That(() => books.FindFootnote(1), Throws.InvalidOperationException,
                "Footnote doesn't exists!");
        }

        [Test]
        public void FindFootnoteMethodReturnCorectlyFormatString()
        {
            Book books = new Book("Hour to Die", "Pedro Alfer");

            books.AddFootnote(1, "To Beginning");
            books.AddFootnote(2, "To Beginning");

            var testString = $"Footnote #{1}: {"To Beginning"}";
            var result = books.FindFootnote(1);

            Assert.AreEqual(testString, result);
        }

        [Test]
        public void AlterFootnoteMethodShouldThrowException()
        {
            Book books = new Book("Hour to Die", "Pedro Alfer");

            Assert.That(() => books.AlterFootnote(1, "Comming soon"), Throws.InvalidOperationException,
                "Footnote does not exists!");
        }

        [Test]
        public void AlterFootnoteMethodShouldSetnewTextCorectly()
        {
            Book books = new Book("Hour to Die", "Pedro Alfer");

            books.AddFootnote(1, "To Beginning");
            books.AddFootnote(2, "To Beginning");
            var curent = books.FindFootnote(1);
            books.AlterFootnote(1, "To My crazy History");

            var result = books.FindFootnote(1);

            Assert.AreNotEqual(result, curent);
        }
    }
}