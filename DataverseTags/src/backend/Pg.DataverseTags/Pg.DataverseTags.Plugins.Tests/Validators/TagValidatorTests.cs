using Microsoft.Xrm.Sdk;
using Pg.DataverseTags.Plugins.Validators;
using Pg.DataverseTags.Shared.Model;
using System;
using Xunit;

namespace Pg.DataverseTags.Plugins.Tests.Validators
{
	public class TagValidatorTests
	{
		[Fact]
		public void IsValid_InvalidEntityType_ReturnsFalse()
		{
			var input = new Entity()
			{
				LogicalName = "account"
			}; 

            var validator = new TagValidator();
            var result = validator.IsValid(input)?.IsValid;
            Assert.False(result);
        }

		[Fact]
		public void IsValid_InvalidInput_ReturnsFalse()
		{
			var input = new pg_tag()
			{
				pg_name = "my-tag-name;"
			}; 
            var validator = new TagValidator();
            var result = validator.IsValid(input)?.IsValid;
            Assert.False(result);
        }

		[Fact]
		public void IsValid_ValidInput_ReturnsTrue()
		{
            var input = new pg_tag()
            {
                pg_name = "my-tag-name"
            };
            var validator = new TagValidator();
			var result = validator.IsValid(input)?.IsValid;
			Assert.True(result); 
		}
	}
}
