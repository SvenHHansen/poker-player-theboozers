using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Nancy.Simple
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestHasOnePairWithNoCards()
        {
            var dc = new DeckClassification();

            var cardList = new List<Card>();

            var result = dc.IsOnePair(cardList);

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void TestHasOnePairWithOneAceAndOneKing()
        {
            var dc = new DeckClassification();

            var cardList = new List<Card>();
            cardList.Add(new Card() { rank = "A", suit = "clubs" });
            cardList.Add(new Card() { rank = "K", suit = "hearts" });

            var result = dc.IsOnePair(cardList);

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void TestHasOnePairWithTwoAces()
        {
            var dc = new DeckClassification();

            var cardList = new List<Card>();
            cardList.Add(new Card() { rank = "A", suit = "clubs" } );
            cardList.Add(new Card() { rank = "A", suit = "hearts" });

            var result = dc.IsOnePair(cardList);

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void TestHasOnePairWithTwoAcesAndTwoKings()
        {
            var dc = new DeckClassification();

            var cardList = new List<Card>();
            cardList.Add(new Card() { rank = "A", suit = "clubs" });
            cardList.Add(new Card() { rank = "A", suit = "hearts" });
            cardList.Add(new Card() { rank = "K", suit = "clubs" });
            cardList.Add(new Card() { rank = "K", suit = "hearts" });
            cardList.Add(new Card() { rank = "6", suit = "hearts" });

            var result = dc.IsOnePair(cardList);

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void TestHasTwoPairWithNoCards()
        {
            var dc = new DeckClassification();

            var cardList = new List<Card>();

            var result = dc.IsTwoPair(cardList);

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void TestHasTwoPairWithOnePairCardsAndOthers()
        {
            var dc = new DeckClassification();

            var cardList = new List<Card>();
            cardList.Add(new Card() { rank = "A", suit = "hearts" });
            cardList.Add(new Card() { rank = "A", suit = "clubs" });
            cardList.Add(new Card() { rank = "D", suit = "hearts" });
            cardList.Add(new Card() { rank = "10", suit = "hearts" });

            var result = dc.IsTwoPair(cardList);

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void TestHasTwoPairWithOnePairCards()
        {
            var dc = new DeckClassification();

            var cardList = new List<Card>();
            cardList.Add(new Card() { rank = "A", suit = "hearts" });
            cardList.Add(new Card() { rank = "A", suit = "hearts" });

            var result = dc.IsTwoPair(cardList);

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void TestHasTwoPairWithTwoPairCards()
        {
            var dc = new DeckClassification();

            var cardList = new List<Card>();
            cardList.Add(new Card() { rank = "A", suit = "hearts" });
            cardList.Add(new Card() { rank = "A", suit = "clubs" });
            cardList.Add(new Card() { rank = "10", suit = "hearts" });
            cardList.Add(new Card() { rank = "10", suit = "clubs" });

            var result = dc.IsTwoPair(cardList);

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void TestHasTwoPairWithTwoPairCardsAndOthers()
        {
            var dc = new DeckClassification();

            var cardList = new List<Card>();
            cardList.Add(new Card() { rank = "A", suit = "hearts" });
            cardList.Add(new Card() { rank = "A", suit = "clubs" });
            cardList.Add(new Card() { rank = "10", suit = "hearts" });
            cardList.Add(new Card() { rank = "10", suit = "clubs" });
            cardList.Add(new Card() { rank = "9", suit = "pik" });

            var result = dc.IsTwoPair(cardList);

            Assert.IsTrue(result);
        }
    }
}
