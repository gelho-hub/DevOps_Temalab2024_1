using StringManipulationApp;


namespace BasicTests
{
    public class BasicTest
    {
        [Fact]
        public void TestFirstStringModulator()
        {
            // Arrange
            Modulator modulator = new Modulator();
            string inputText = "madarnyelv";
            string expected = "mavadavarnyevelv"; // Expected output after modulating

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