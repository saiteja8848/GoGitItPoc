using System;
using System.Collections.Generic;
using Algorithms.Search;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Alogrithms.Test
{
	[TestClass]
	public class BinarySearcherTest
	{
		[TestMethod]
		public void IntBinarySearchTest()
		{
			//list of ints
			IList<int> list = new List<int> { 9, 3, 7, 1, 6, 10 };
			IList<int> sortedList = new List<int> { 1, 3, 6, 7, 9, 10 };
			int numToSearch = 6;
			BinarySearcher<int> intSearcher = new BinarySearcher<int>(list, Comparer<int>.Default);
			int actualIndex = intSearcher.BinarySearch(numToSearch);
			int expectedIndex = sortedList.IndexOf(numToSearch);

			Assert.AreEqual(expectedIndex, actualIndex);
			Assert.AreEqual(numToSearch, intSearcher.Current);

			numToSearch = 20;
			int itemNotExists = intSearcher.BinarySearch(numToSearch);
			Assert.AreEqual(-1, itemNotExists);
		}

		[TestMethod]
		public static void StringBinarySearchTest()
		{
			//list of strings
			IList<string> animals = new List<string> { "lion", "cat", "tiger", "bee", "sparrow" };
			IList<string> sortedAnimals = new List<string> { "bee", "cat", "lion", "sparrow", "tiger" };
			string itemToSearch = "bee";
			BinarySearcher<string> strSearcher = new BinarySearcher<string>(animals, Comparer<string>.Default);
			int actualIndex = strSearcher.BinarySearch(itemToSearch);
			int expectedAnimalIndex = sortedAnimals.IndexOf(itemToSearch);

			Assert.AreEqual(expectedAnimalIndex, actualIndex);
			Assert.AreEqual(itemToSearch, strSearcher.Current);

			itemToSearch = "shark";
			int itemNotExist = strSearcher.BinarySearch(itemToSearch);
			Assert.AreEqual(-1, itemNotExist);
		}

		[TestMethod]
		public static void MoveNextTest()
		{
			IList<int> items = new List<int> { 3, 5, 2, 6, 1, 4 };
			BinarySearcher<int> searcher = new BinarySearcher<int>(items, Comparer<int>.Default);
			searcher.BinarySearch(1);
			//reset indices to test MoveNext()
			searcher.Reset();
			IList<int> leftEnumeratedValues = new List<int> { 3, 2, 1 };
			int i = 0;
			while (searcher.MoveNext())
			{
				Assert.AreEqual(leftEnumeratedValues[i++], searcher.Current);
			}

			searcher.BinarySearch(6);
			//reset indices to test MoveNext()
			searcher.Reset();
			IList<int> rightEnumeratedValues = new List<int> { 3, 5, 6 };
			i = 0;
			while (searcher.MoveNext())
			{
				Assert.AreEqual(rightEnumeratedValues[i++], searcher.Current);
			}

		}

		[TestMethod]
		public static void NullCollectionExceptionTest()
		{
			IList<int> list = null;
			Assert.ThrowsException<System.NullReferenceException>(() => new BinarySearcher<int>(list, Comparer<int>.Default));
		}

	}
}
