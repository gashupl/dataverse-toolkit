using Pg.DataverseTags.Plugins.Validators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Pg.DataverseTags.Plugins.Tests.Validators
{
    public class IsValidResponseTests
    {
        [Fact]
        public void GetErrors_ErrorsExists_ReturnErrors()
        {
            var expected = $"Message 1{Environment.NewLine}Message 2"; 
            var response = new IsValidResponse();
            response.Errors = new List<string>() { "Message 1", "Message 2" };
            var actual = response.GetErrors();
            Assert.Equal(expected, actual); 
        }

        [Fact]
        public void GetErrors_NoErrors_ReturnEmptyString()
        {
            var expected = String.Empty; 
            var response = new IsValidResponse();
            var actual = response.GetErrors();
            Assert.Equal(expected, actual);
        }
    }
}
