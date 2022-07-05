using FluentAssertions;
using Structr.Security;
using System;
using Xunit;

namespace Structr.Tests.Security
{
    public class Pbkdf2HasherTests
    {
        [Theory]
        [InlineData("Hash test_phrase 123 !@#", true)]
        [InlineData("Hash test_phrase 456 !@#", false)]
        [InlineData("Abc", false)]
        public void Hash_could_be_verified(string value, bool isValid)
        {
            // Arrange
            var hash = Pbkdf2Hasher.Hash("Hash test_phrase 123 !@#");

            // Act
            var result = Pbkdf2Hasher.Verify(hash, value);

            // Assert
            result.Should().Be(isValid);
        }

        [Fact]
        public void Hash_throws_when_input_is_null_or_empty()
        {
            // Act
            Action act = () => Pbkdf2Hasher.Hash("");

            // Assert
            act.Should().Throw<ArgumentNullException>().WithMessage("*input*");
        }

        [Fact]
        public void Verify_fails_when_hash_is_null()
        {
            // Act
            var result = Pbkdf2Hasher.Verify(null, "abc");

            // Assert
            result.Should().BeFalse();
        }

        [Fact]
        public void Verify_throws_when_input_is_null_or_empty()
        {
            // Act
            Action act = () => Pbkdf2Hasher.Verify("=qwe123", "");

            // Assert
            act.Should().Throw<ArgumentNullException>().WithMessage("*input*");
        }

        [Fact]
        public void Throws_when_passphrase_is_null_or_empty()
        {
            // Act
            Action act = () => StringEncryptor.Encrypt("abc", "");

            // Assert
            act.Should().Throw<ArgumentNullException>().WithMessage("*passphrase*");
        }
    }
}