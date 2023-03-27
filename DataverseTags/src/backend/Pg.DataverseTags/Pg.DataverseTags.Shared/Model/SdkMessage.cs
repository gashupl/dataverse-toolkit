//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------


namespace Pg.DataverseTags.Shared.Model
{
	
	/// <summary>
	/// Message that is supported by the SDK.
	/// </summary>
	[System.Runtime.Serialization.DataContractAttribute()]
	[Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("sdkmessage")]
	public partial class SdkMessage : Microsoft.Xrm.Sdk.Entity, System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		public static class Fields
		{
			public const string autotransact = "autotransact";
			public const string availability = "availability";
			public const string categoryname = "categoryname";
			public const string componentstate = "componentstate";
			public const string createdby = "createdby";
			public const string createdon = "createdon";
			public const string createdonbehalfby = "createdonbehalfby";
			public const string customizationlevel = "customizationlevel";
			public const string executeprivilegename = "executeprivilegename";
			public const string expand = "expand";
			public const string introducedversion = "introducedversion";
			public const string isactive = "isactive";
			public const string ismanaged = "ismanaged";
			public const string isprivate = "isprivate";
			public const string isreadonly = "isreadonly";
			public const string isvalidforexecuteasync = "isvalidforexecuteasync";
			public const string modifiedby = "modifiedby";
			public const string modifiedon = "modifiedon";
			public const string modifiedonbehalfby = "modifiedonbehalfby";
			public const string name = "name";
			public const string organizationid = "organizationid";
			public const string overwritetime = "overwritetime";
			public const string sdkmessageid = "sdkmessageid";
			public const string Id = "sdkmessageid";
			public const string sdkmessageidunique = "sdkmessageidunique";
			public const string solutionid = "solutionid";
			public const string template = "template";
			public const string throttlesettings = "throttlesettings";
			public const string versionnumber = "versionnumber";
			public const string workflowsdkstepenabled = "workflowsdkstepenabled";
		}
		
		/// <summary>
		/// Default Constructor.
		/// </summary>
		[System.Diagnostics.DebuggerNonUserCode()]
		public SdkMessage() : 
				base(EntityLogicalName)
		{
		}
		
		public const string EntityLogicalName = "sdkmessage";
		
		public const string EntitySchemaName = "SdkMessage";
		
		public const string PrimaryIdAttribute = "sdkmessageid";
		
		public const string PrimaryNameAttribute = "name";
		
		public const string EntityLogicalCollectionName = "sdkmessages";
		
		public const string EntitySetName = "sdkmessages";
		
		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		
		public event System.ComponentModel.PropertyChangingEventHandler PropertyChanging;
		
		[System.Diagnostics.DebuggerNonUserCode()]
		private void OnPropertyChanged(string propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}
		
		[System.Diagnostics.DebuggerNonUserCode()]
		private void OnPropertyChanging(string propertyName)
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, new System.ComponentModel.PropertyChangingEventArgs(propertyName));
			}
		}
		
		/// <summary>
		/// Information about whether the SDK message is automatically transacted.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("autotransact")]
		public System.Nullable<bool> autotransact
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<bool>>("autotransact");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("autotransact");
				this.SetAttributeValue("autotransact", value);
				this.OnPropertyChanged("autotransact");
			}
		}
		
		/// <summary>
		/// Identifies where a method will be exposed. 0 - Server, 1 - Client, 2 - both.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("availability")]
		public System.Nullable<int> availability
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("availability");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("availability");
				this.SetAttributeValue("availability", value);
				this.OnPropertyChanged("availability");
			}
		}
		
		/// <summary>
		/// If this is a categorized method, this is the name, otherwise None.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("categoryname")]
		public string categoryname
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("categoryname");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("categoryname");
				this.SetAttributeValue("categoryname", value);
				this.OnPropertyChanged("categoryname");
			}
		}
		
		/// <summary>
		/// For internal use only.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("componentstate")]
		public virtual ComponentState? componentstate
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return ((ComponentState?)(EntityOptionSetEnum.GetEnum(this, "componentstate")));
			}
		}
		
		/// <summary>
		/// Unique identifier of the user who created the SDK message.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
		public Microsoft.Xrm.Sdk.EntityReference createdby
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("createdby");
			}
		}
		
		/// <summary>
		/// Date and time when the SDK message was created.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdon")]
		public System.Nullable<System.DateTime> createdon
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<System.DateTime>>("createdon");
			}
		}
		
		/// <summary>
		/// Unique identifier of the delegate user who created the sdkmessage.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
		public Microsoft.Xrm.Sdk.EntityReference createdonbehalfby
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("createdonbehalfby");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("createdonbehalfby");
				this.SetAttributeValue("createdonbehalfby", value);
				this.OnPropertyChanged("createdonbehalfby");
			}
		}
		
		/// <summary>
		/// Customization level of the SDK message.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("customizationlevel")]
		public System.Nullable<int> customizationlevel
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("customizationlevel");
			}
		}
		
		/// <summary>
		/// Name of the privilege that allows execution of the SDK message
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("executeprivilegename")]
		public string executeprivilegename
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("executeprivilegename");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("executeprivilegename");
				this.SetAttributeValue("executeprivilegename", value);
				this.OnPropertyChanged("executeprivilegename");
			}
		}
		
		/// <summary>
		/// Indicates whether the SDK message should have its requests expanded per primary entity defined in its filters.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("expand")]
		public System.Nullable<bool> expand
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<bool>>("expand");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("expand");
				this.SetAttributeValue("expand", value);
				this.OnPropertyChanged("expand");
			}
		}
		
		/// <summary>
		/// Version in which the component is introduced.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("introducedversion")]
		public string introducedversion
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("introducedversion");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("introducedversion");
				this.SetAttributeValue("introducedversion", value);
				this.OnPropertyChanged("introducedversion");
			}
		}
		
		/// <summary>
		/// Information about whether the SDK message is active.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("isactive")]
		public System.Nullable<bool> isactive
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<bool>>("isactive");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("isactive");
				this.SetAttributeValue("isactive", value);
				this.OnPropertyChanged("isactive");
			}
		}
		
		/// <summary>
		/// Information that specifies whether this component is managed.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("ismanaged")]
		public System.Nullable<bool> ismanaged
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<bool>>("ismanaged");
			}
		}
		
		/// <summary>
		/// Indicates whether the SDK message is private.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("isprivate")]
		public System.Nullable<bool> isprivate
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<bool>>("isprivate");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("isprivate");
				this.SetAttributeValue("isprivate", value);
				this.OnPropertyChanged("isprivate");
			}
		}
		
		/// <summary>
		/// Identifies whether an SDK message will be ReadOnly or Read Write. false - ReadWrite, true - ReadOnly .
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("isreadonly")]
		public System.Nullable<bool> isreadonly
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<bool>>("isreadonly");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("isreadonly");
				this.SetAttributeValue("isreadonly", value);
				this.OnPropertyChanged("isreadonly");
			}
		}
		
		/// <summary>
		/// For internal use only.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("isvalidforexecuteasync")]
		public System.Nullable<bool> isvalidforexecuteasync
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<bool>>("isvalidforexecuteasync");
			}
		}
		
		/// <summary>
		/// Unique identifier of the user who last modified the SDK message.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
		public Microsoft.Xrm.Sdk.EntityReference modifiedby
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("modifiedby");
			}
		}
		
		/// <summary>
		/// Date and time when the SDK message was last modified.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedon")]
		public System.Nullable<System.DateTime> modifiedon
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<System.DateTime>>("modifiedon");
			}
		}
		
		/// <summary>
		/// Unique identifier of the delegate user who last modified the sdkmessage.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
		public Microsoft.Xrm.Sdk.EntityReference modifiedonbehalfby
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("modifiedonbehalfby");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("modifiedonbehalfby");
				this.SetAttributeValue("modifiedonbehalfby", value);
				this.OnPropertyChanged("modifiedonbehalfby");
			}
		}
		
		/// <summary>
		/// Name of the SDK message.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("name")]
		public string name
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("name");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("name");
				this.SetAttributeValue("name", value);
				this.OnPropertyChanged("name");
			}
		}
		
		/// <summary>
		/// Unique identifier of the organization with which the SDK message is associated.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("organizationid")]
		public Microsoft.Xrm.Sdk.EntityReference organizationid
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("organizationid");
			}
		}
		
		/// <summary>
		/// For internal use only.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("overwritetime")]
		public System.Nullable<System.DateTime> overwritetime
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<System.DateTime>>("overwritetime");
			}
		}
		
		/// <summary>
		/// Unique identifier of the SDK message entity.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("sdkmessageid")]
		public System.Nullable<System.Guid> sdkmessageid
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<System.Guid>>("sdkmessageid");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("sdkmessageid");
				this.SetAttributeValue("sdkmessageid", value);
				if (value.HasValue)
				{
					base.Id = value.Value;
				}
				else
				{
					base.Id = System.Guid.Empty;
				}
				this.OnPropertyChanged("sdkmessageid");
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("sdkmessageid")]
		public override System.Guid Id
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return base.Id;
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.sdkmessageid = value;
			}
		}
		
		/// <summary>
		/// Unique identifier of the SDK message.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("sdkmessageidunique")]
		public System.Nullable<System.Guid> sdkmessageidunique
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<System.Guid>>("sdkmessageidunique");
			}
		}
		
		/// <summary>
		/// Unique identifier of the associated solution.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("solutionid")]
		public System.Nullable<System.Guid> solutionid
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<System.Guid>>("solutionid");
			}
		}
		
		/// <summary>
		/// Indicates whether the SDK message is a template.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("template")]
		public System.Nullable<bool> template
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<bool>>("template");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("template");
				this.SetAttributeValue("template", value);
				this.OnPropertyChanged("template");
			}
		}
		
		/// <summary>
		/// For internal use only.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("throttlesettings")]
		public string throttlesettings
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("throttlesettings");
			}
		}
		
		/// <summary>
		/// Number that identifies a specific revision of the SDK message. 
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("versionnumber")]
		public System.Nullable<long> versionnumber
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<long>>("versionnumber");
			}
		}
		
		/// <summary>
		/// Whether or not the SDK message can be called from a workflow.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("workflowsdkstepenabled")]
		public System.Nullable<bool> workflowsdkstepenabled
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<bool>>("workflowsdkstepenabled");
			}
		}
		
		/// <summary>
		/// 1:N sdkmessageid_sdkmessagefilter
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("sdkmessageid_sdkmessagefilter")]
		public System.Collections.Generic.IEnumerable<Pg.DataverseTags.Shared.Model.SdkMessageFilter> sdkmessageid_sdkmessagefilter
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<Pg.DataverseTags.Shared.Model.SdkMessageFilter>("sdkmessageid_sdkmessagefilter", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("sdkmessageid_sdkmessagefilter");
				this.SetRelatedEntities<Pg.DataverseTags.Shared.Model.SdkMessageFilter>("sdkmessageid_sdkmessagefilter", null, value);
				this.OnPropertyChanged("sdkmessageid_sdkmessagefilter");
			}
		}
		
		/// <summary>
		/// 1:N sdkmessageid_sdkmessageprocessingstep
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("sdkmessageid_sdkmessageprocessingstep")]
		public System.Collections.Generic.IEnumerable<Pg.DataverseTags.Shared.Model.SdkMessageProcessingStep> sdkmessageid_sdkmessageprocessingstep
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<Pg.DataverseTags.Shared.Model.SdkMessageProcessingStep>("sdkmessageid_sdkmessageprocessingstep", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("sdkmessageid_sdkmessageprocessingstep");
				this.SetRelatedEntities<Pg.DataverseTags.Shared.Model.SdkMessageProcessingStep>("sdkmessageid_sdkmessageprocessingstep", null, value);
				this.OnPropertyChanged("sdkmessageid_sdkmessageprocessingstep");
			}
		}
		
		/// <summary>
		/// Constructor for populating via LINQ queries given a LINQ anonymous type
		/// <param name="anonymousType">LINQ anonymous type.</param>
		/// </summary>
		[System.Diagnostics.DebuggerNonUserCode()]
		public SdkMessage(object anonymousType) : 
				this()
		{
            foreach (var p in anonymousType.GetType().GetProperties())
            {
                var value = p.GetValue(anonymousType, null);
                var name = p.Name.ToLower();
            
                if (name.EndsWith("enum") && value.GetType().BaseType == typeof(System.Enum))
                {
                    value = new Microsoft.Xrm.Sdk.OptionSetValue((int) value);
                    name = name.Remove(name.Length - "enum".Length);
                }
            
                switch (name)
                {
                    case "id":
                        base.Id = (System.Guid)value;
                        Attributes["sdkmessageid"] = base.Id;
                        break;
                    case "sdkmessageid":
                        var id = (System.Nullable<System.Guid>) value;
                        if(id == null){ continue; }
                        base.Id = id.Value;
                        Attributes[name] = base.Id;
                        break;
                    case "formattedvalues":
                        // Add Support for FormattedValues
                        FormattedValues.AddRange((Microsoft.Xrm.Sdk.FormattedValueCollection)value);
                        break;
                    default:
                        Attributes[name] = value;
                        break;
                }
            }
		}
	}
}