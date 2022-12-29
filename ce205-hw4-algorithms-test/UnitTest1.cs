using ce205_hw4_algorithms_cs;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace ce205_hw4_algorithms_test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void NeedlemanWunsch_TestAlign_SameSequences()
        {
            string sequence1 = "ACGTACGT";
            string sequence2 = "ACGTACGT";
            (string aligned1, string aligned2) = NeedlemanWunsch.Align(sequence1, sequence2);

            Assert.AreEqual(sequence1, aligned1, "Aligned sequences do not match the original sequences.");
            Assert.AreEqual(sequence2, aligned2, "Aligned sequences do not match the original sequences.");
        }

        [TestMethod]
        public void NeedlemanWunsch_TestAlign_DifferentSequences()
        {
            string sequence1 = "ACGTACGT";
            string sequence2 = "CGATCGAT";
            (string aligned1, string aligned2) = NeedlemanWunsch.Align(sequence1, sequence2);

            Assert.AreEqual("ACGTA-CG-T", aligned1, "Aligned sequences are not correct.");
            Assert.AreEqual("-CG-ATCGAT", aligned2, "Aligned sequences are not correct.");
        }

        [TestMethod]
        public void NeedlemanWunsch_TestAlign_OneSequenceIsSubsequenceOfOther()
        {
            string sequence1 = "ACGTACGTACGT";
            string sequence2 = "CGTACGT";
            (string aligned1, string aligned2) = NeedlemanWunsch.Align(sequence1, sequence2);

            Assert.AreEqual("ACGTACGTACGT", aligned1, "Aligned sequences are not correct.");
            Assert.AreEqual("-----CGTACGT", aligned2, "Aligned sequences are not correct.");
        }

        [TestMethod]
        public void NeedlemanWunsch_TestAlign_EmptySequences()
        {
            string sequence1 = "";
            string sequence2 = "";
            (string aligned1, string aligned2) = NeedlemanWunsch.Align(sequence1, sequence2);

            Assert.AreEqual("", aligned1, "Aligned sequences are not correct.");
            Assert.AreEqual("", aligned2, "Aligned sequences are not correct.");
        }

        [TestMethod]
        public void HuntSzymanski_Search_KeywordFound_ReturnsCorrectIndex()
        {
            // Arrange
            string text = "The quick brown fox jumps over the lazy dog.";
            string keyword = "fox";

            // Act
            int index = HuntSzymanski.Search(text, keyword);

            // Assert
            Assert.AreEqual(16, index);
        }

        [TestMethod]
        public void HuntSzymanski_Search_KeywordNotFound_ReturnsMinusOne()
        {
            // Arrange
            string text = "The quick brown fox jumps over the lazy dog.";
            string keyword = "cat";

            // Act
            int index = HuntSzymanski.Search(text, keyword);

            // Assert
            Assert.AreEqual(-1, index);
        }

        [TestMethod]
        public void HuntSzymanski_Search_KeywordIsEmpty_ReturnsMinusOne()
        {
            // Arrange
            string text = "The quick brown fox jumps over the lazy dog.";
            string keyword = "";

            // Act
            int index = HuntSzymanski.Search(text, keyword);

            // Assert
            Assert.AreEqual(0, index);
        }

        [TestMethod]
        public void HuntSzymanski_Search_TextIsEmpty_ReturnsMinusOne()
        {
            // Arrange
            string text = "";
            string keyword = "fox";

            // Act
            int index = HuntSzymanski.Search(text, keyword);

            // Assert
            Assert.AreEqual(-1, index);
        }

        [TestMethod]
        public void KnuthMorrisPratt_Search_KeywordFound_ReturnsCorrectIndex()
        {
            // Arrange
            string text = "The quick brown fox jumps over the lazy dog.";
            string keyword = "fox";

            // Act
            int index = KnuthMorrisPratt.Search(text, keyword);

            // Assert
            Assert.AreEqual(-1, index);
        }

        [TestMethod]
        public void KnuthMorrisPratt_Search_KeywordNotFound_ReturnsMinusOne()
        {
            // Arrange
            string text = "The quick brown fox jumps over the lazy dog.";
            string keyword = "cat";

            // Act
            int index = KnuthMorrisPratt.Search(text, keyword);

            // Assert
            Assert.AreEqual(-1, index);
        }

        [TestMethod]
        public void Horspool_Search_KeywordFound_ReturnsCorrectIndex()
        {
            // Arrange
            string text = "The quick brown fox jumps over the lazy dog.";
            string keyword = "fox";

            // Act
            int index = Horspool.Search(text, keyword);

            // Assert
            Assert.AreEqual(16, index);
        }

        [TestMethod]
        public void Horspool_Search_KeywordNotFound_ReturnsMinusOne()
        {
            // Arrange
            string text = "The quick brown fox jumps over the lazy dog.";
            string keyword = "cat";

            // Act
            int index = Horspool.Search(text, keyword);

            // Assert
            Assert.AreEqual(-1, index);
        }

        [TestMethod]
        public void Horspool_Search_KeywordIsEmpty_ReturnsMinusOne()
        {
            // Arrange
            string text = "The quick brown fox jumps over the lazy dog.";
            string keyword = "";

            // Act
            int index = Horspool.Search(text, keyword);

            // Assert
            Assert.AreEqual(-1, index);
        }

        [TestMethod]
        public void Horspool_Search_TextIsEmpty_ReturnsMinusOne()
        {
            // Arrange
            string text = "";
            string keyword = "fox";

            // Act
            int index = Horspool.Search(text, keyword);

            // Assert
            Assert.AreEqual(-1, index);
        }

        [TestMethod]
        public void Horspool_Search_TextAndKeywordAreEmpty_ReturnsMinusOne()
        {
            // Arrange
            string text = "";
            string keyword = "";

            // Act
            int index = Horspool.Search(text, keyword);

            // Assert
            Assert.AreEqual(-1, index);
        }
        [TestMethod]
        public void BoyerMoore_TestSearch_WithMatchingKeyword_ReturnsCorrectIndex()
        {
            // Arrange
            string text = "The quick brown fox jumps over the lazy dog.";
            string keyword = "jumps";

            // Act
            int index = BoyerMoore.Search(text, keyword);

            // Assert
            Assert.AreEqual(20, index);
        }

        [TestMethod]
        public void BoyerMoore_TestSearch_WithNonMatchingKeyword_ReturnsMinusOne()
        {
            // Arrange
            string text = "The quick brown fox jumps over the lazy dog.";
            string keyword = "jumped";

            // Act
            int index = BoyerMoore.Search(text, keyword);

            // Assert
            Assert.AreEqual(-1, index);
        }

        [TestMethod]
        public void BoyerMoore_TestSearch_WithEmptyKeyword_ReturnsMinusOne()
        {
            // Arrange
            string text = "The quick brown fox jumps over the lazy dog.";
            string keyword = "";

            // Act
            int index = BoyerMoore.Search(text, keyword);

            // Assert
            Assert.AreEqual(-1, index);
        }

        [TestMethod]
        public void Trie_TestInsertAndSearch()
        {
            Trie trie = new Trie();
            Trie.Insert("cat");
            Trie.Insert("dog");
            Trie.Insert("cats");
            Trie.Insert("dogs");

            Assert.IsTrue(Trie.Search("cat"));
            Assert.IsTrue(Trie.Search("dog"));
            Assert.IsTrue(Trie.Search("cats"));
            Assert.IsTrue(Trie.Search("dogs"));

            Assert.IsFalse(Trie.Search("ca"));
            Assert.IsFalse(Trie.Search("do"));
            Assert.IsFalse(Trie.Search("catt"));
            Assert.IsFalse(Trie.Search("dogg"));
        }

        [TestMethod]
        public void Trie_TestStartsWith()
        {
            Trie trie = new Trie();
            Trie.Insert("cat");
            Trie.Insert("dog");
            Trie.Insert("cats");
            Trie.Insert("dogs");

            Assert.IsTrue(Trie.StartsWith("ca"));
            Assert.IsTrue(Trie.StartsWith("do"));
            Assert.IsTrue(Trie.StartsWith("cats"));
            Assert.IsTrue(Trie.StartsWith("dogs"));
            Assert.IsFalse(Trie.StartsWith("catss"));
        }

        [TestMethod]
        public void SmithWaterman_TestCompute1()
        {
            // Test with two identical sequences.
            var sw = new SmithWaterman("ATGC", "ATGC", -1);
            int score = sw.Compute();
            Assert.AreEqual(8, score);
            // Test with two different sequences.
            sw = new SmithWaterman("ATGC", "TTGC", -1);
            score = sw.Compute();
            Assert.AreEqual(5, score);
            // Test with longer sequences.
            sw = new SmithWaterman("AGTACGCA", "TACGCATA", -2);
            score = sw.Compute();
            Assert.AreEqual(12, score);
        }
    }
}
