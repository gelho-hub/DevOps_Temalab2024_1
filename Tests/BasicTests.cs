using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StringManipulationApp;

namespace Tests
{
    public class BasicTests
    {
        [Fact]
        public void TestFirstStringModulator()
        {
            // Arrange
            Modulator modulator = new Modulator();
            string inputText = "madárnyelv";
            string expected = "mavadávárnyevelv"; // Expected output after modulating

            // Act
            string actual = modulator.FirstStringModulator(inputText);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestSqueeze()
        {
            // Arrange
            Modulator modulator = new Modulator();
            string inputText = "megadott sztring";
            string removableText = "gt";
            string expected = "meado szrin"; // Expected output after squeezing

            // Act
            string actual = modulator.Squeeze(inputText, removableText);

            // Assert
            Assert.Equal(expected, actual);
        }
    }
}
