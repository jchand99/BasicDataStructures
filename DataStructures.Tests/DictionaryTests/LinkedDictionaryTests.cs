/*
Author: Jacob Chandler
File: LinkedDictionaryTests.cs
Version: 1.0.1
Description: This file contians NUnit test functionality for the LinkedDictionary Data Structure class.
Date of Comment: 06:15:18 
*/

using System;
using NUnit.Framework;
using DataStructures.Dictionaries;

namespace Tests.DictionaryTests {

    public class LinkedDictionaryTests {

        LinkedDictionary<int, string> Dictionary = new LinkedDictionary<int, string>();

        [SetUp]
        public void Setup() {
            Dictionary.Add(1, "Phil");
            Dictionary.Add(12, "Phillip");
            Dictionary.Add(34, "Frank");
            Dictionary.Add(54, "Bobby");
        }

        [Test]
        public void CountTest() {
            Assert.AreEqual(4, Dictionary.Count);
        }

        [Test]
        public void AddTest() {
            Dictionary.Add(40, "Billy");
            Assert.True(Dictionary.Contains(40));
        }

        [Test]
        public void RemoveTest() {
            Dictionary.Remove(1);
            Assert.False(Dictionary.Contains(1));
        }

        [Test]
        public void GetValueTest() {
            Assert.AreEqual("Phillip", Dictionary.GetValue(12));
        }

        [Test]
        public void ContainsTest() {
            Assert.True(Dictionary.Contains(34));
        }

        [Test]
        public void IsEmptyTest() {
            Dictionary.Empty();
            Assert.True(Dictionary.IsEmpty());
        }

        [Test]
        public void IsEmptyTestTwo() {
            Assert.False(Dictionary.IsEmpty());
        }

        // TODO: Exception tests.
    }

}