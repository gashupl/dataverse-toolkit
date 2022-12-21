using Microsoft.Xrm.Sdk;
using Pg.DataverseTags.Shared.Model;
using System;
using System.Collections.Generic;

namespace Pg.DataverseTags.Plugins.Validators
{
	internal class TagValidator : IValidator
	{
		private const string ValidationErrorMessage = "Semicolon (';') character is not allowed";
        private const string InvalidEntityErrorMessage = "Not a valid entity type"; 
        public IsValidResponse IsValid(Entity input)
		{
            if (!input.LogicalName.Equals(pg_tag.EntityLogicalName))
            {
                return new IsValidResponse()
                {
                    IsValid = false,
                    Errors = new List<string>() { InvalidEntityErrorMessage }
                };
            }

            var tagEntity = input.ToEntity<pg_tag>(); 

			if (tagEntity.pg_name.Contains(";"))
			{
                return new IsValidResponse()
                {
                    IsValid = false,
                    Errors = new List<string>() { ValidationErrorMessage }
                };
            }
			else
			{
                return new IsValidResponse()
                {
                    IsValid = true
                };
            }
		}
	}
}
