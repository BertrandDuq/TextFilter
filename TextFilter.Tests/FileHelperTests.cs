using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;

namespace TextFilter.Tests
{
    [TestFixture]
    public class FileHelperTests
    {
        private string _filePath;

        [OneTimeSetUp]
        public void Setup()
        {
            _filePath = @"..\..\..\..\Input\input1.txt";
        }

        [Test]
        public void Should_GetFileLines_DoesNotThrow()
        {
            Assert.DoesNotThrow(() => FileHelper.FileHelper.GetFileLines(_filePath));
        }
        
        [Test]
        public void Should_GetFileLines_HasAny()
        {
            var lines = FileHelper.FileHelper.GetFileLines(_filePath);
            
            Assert.That(lines.Any());
        }

        [Test]
        public void Should_GetWordsList_DoesNotThrow()
        {
            Assert.DoesNotThrow(() => GetWordsList());
        }

        [Test]
        public void Should_GetWordsList_HasAny()
        {
            var words = GetWordsList();

            Assert.That(words.Any());
        }

        private IEnumerable<string> GetWordsList()
        {
            var lines = FileHelper.FileHelper.GetFileLines(_filePath);
            return FileHelper.FileHelper.GetWordsList(lines);
        }
    }
}