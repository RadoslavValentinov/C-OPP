namespace Book.Tests
{
    using System;

    using NUnit.Framework;

    public class Tests
    {
        [Test]
        public void TestConstructorSetValueAndDictionary()
        {
            Book book = new Book("War", "Ardam Serio");

            Assert.AreEqual(book.BookName,"War");
            Assert.AreEqual(book.Author, "Ardam Serio");
        }

        [Test]
        public void TestPropertyCountWorkCorectly()
        {
            Book book = new Book("War", "Ardam Serio");

            book.AddFootnote(1,"Set Elemrnts To Dictionary");
            Assert.AreEqual(1,book.FootnoteCount);
        }

        [TestCase(null,"George Soer")]
        [TestCase("","George Soer")]
        public void TestPropertyBookNameThrowExceptions(string bookName,string author)
        {
            Assert.Throws<ArgumentException>(() => new Book(bookName, author), $"Invalid BookName!");
        }

        [TestCase("Second War", null)]
        [TestCase("Thunder","")]
        public void TestPropertyAuthorThrowExceptions(string bookName, string author)
        {
            Assert.Throws<ArgumentException>(() => new Book(bookName, author), $"Invalid Author!");
        }

        [Test]
        public void TestMethodAddFootnoteSetCorectlyValue()
        {
            Book book = new Book("Rain", "Jeyms Sell");

            book.AddFootnote(1,"Carls is da day of Paradays");
            book.AddFootnote(2,"Carls is da day of Paradays");

            Assert.AreEqual(book.FindFootnote(1), $"Footnote #{1}: {"Carls is da day of Paradays"}");
            Assert.AreEqual(book.FindFootnote(2), $"Footnote #{2}: {"Carls is da day of Paradays"}");
        }
        [Test]
        public void TestMethodAddFootnoteShouldThrowException()
        {
            Book book = new Book("Rain", "Jeyms Sell");

            book.AddFootnote(1, "Carls is da day of Paradays");
            Assert.Throws<InvalidOperationException>(() => book.AddFootnote(1, "Carls is da day of Paradays"),
                "Footnote doesn't exists!");
        }
        [Test]
        public void TestMethodFindFootnoteShouldThrowException()
        {
            Book book = new Book("Rain", "Jeyms Sell");

            book.AddFootnote(1, "Carls is da day of Paradays");
            Assert.Throws<InvalidOperationException>(() => book.FindFootnote(3),
                "Footnote doesn't exists!");
        }

        [Test]
        public void TestMethodAlterFootnoteSetNewTextCorectly()
        {
            Book book = new Book("Rain", "Jeyms Sell");

            book.AddFootnote(1, "Carls is da day of Paradays");

            book.AlterFootnote(1, "Go Home");

            Assert.AreEqual(book.FindFootnote(1), $"Footnote #{1}: {"Go Home"}");
        }

        [Test]
        public void TestMethodAlterFootnoteThrowException()
        {
            Book book = new Book("Rain", "Jeyms Sell");

            book.AddFootnote(1, "Carls is da day of Paradays");

            Assert.Throws<InvalidOperationException>(() => book.AlterFootnote(3, "Take"),
                "Footnote does not exists!");
        }
    }
}