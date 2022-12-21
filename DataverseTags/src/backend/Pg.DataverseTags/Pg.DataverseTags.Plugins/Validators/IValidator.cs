using Microsoft.Xrm.Sdk;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pg.DataverseTags.Plugins.Validators
{
	internal interface IValidator
	{
		IsValidResponse IsValid(Entity input); 
	}
}
