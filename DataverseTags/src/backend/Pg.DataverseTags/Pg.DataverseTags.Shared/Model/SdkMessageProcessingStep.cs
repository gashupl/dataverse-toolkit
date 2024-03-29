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
	
	[System.Runtime.Serialization.DataContractAttribute()]
	public enum SdkMessageProcessingStepState
	{
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		Enabled = 0,
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		Disabled = 1,
	}
	
	/// <summary>
	/// Stage in the execution pipeline that a plug-in is to execute.
	/// </summary>
	[System.Runtime.Serialization.DataContractAttribute()]
	[Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("sdkmessageprocessingstep")]
	public partial class SdkMessageProcessingStep : Microsoft.Xrm.Sdk.Entity, System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		public static class Fields
		{
			public const string asyncautodelete = "asyncautodelete";
			public const string canusereadonlyconnection = "canusereadonlyconnection";
			public const string category = "category";
			public const string componentstate = "componentstate";
			public const string configuration = "configuration";
			public const string createdby = "createdby";
			public const string createdon = "createdon";
			public const string createdonbehalfby = "createdonbehalfby";
			public const string customizationlevel = "customizationlevel";
			public const string description = "description";
			public const string enablepluginprofiler = "enablepluginprofiler";
			public const string eventexpander = "eventexpander";
			public const string eventhandler = "eventhandler";
			public const string filteringattributes = "filteringattributes";
			public const string impersonatinguserid = "impersonatinguserid";
			public const string introducedversion = "introducedversion";
			public const string invocationsource = "invocationsource";
			public const string iscustomizable = "iscustomizable";
			public const string ishidden = "ishidden";
			public const string ismanaged = "ismanaged";
			public const string mode = "mode";
			public const string modifiedby = "modifiedby";
			public const string modifiedon = "modifiedon";
			public const string modifiedonbehalfby = "modifiedonbehalfby";
			public const string name = "name";
			public const string organizationid = "organizationid";
			public const string overwritetime = "overwritetime";
			public const string plugintypeid = "plugintypeid";
			public const string powerfxruleid = "powerfxruleid";
			public const string rank = "rank";
			public const string runtimeintegrationproperties = "runtimeintegrationproperties";
			public const string sdkmessagefilterid = "sdkmessagefilterid";
			public const string sdkmessageid = "sdkmessageid";
			public const string sdkmessageprocessingstepid = "sdkmessageprocessingstepid";
			public const string Id = "sdkmessageprocessingstepid";
			public const string sdkmessageprocessingstepidunique = "sdkmessageprocessingstepidunique";
			public const string sdkmessageprocessingstepsecureconfigid = "sdkmessageprocessingstepsecureconfigid";
			public const string solutionid = "solutionid";
			public const string stage = "stage";
			public const string statecode = "statecode";
			public const string statuscode = "statuscode";
			public const string supporteddeployment = "supporteddeployment";
			public const string versionnumber = "versionnumber";
			public const string plugintype_sdkmessageprocessingstep = "plugintype_sdkmessageprocessingstep";
			public const string plugintypeid_sdkmessageprocessingstep = "plugintypeid_sdkmessageprocessingstep";
			public const string sdkmessagefilterid_sdkmessageprocessingstep = "sdkmessagefilterid_sdkmessageprocessingstep";
			public const string sdkmessageid_sdkmessageprocessingstep = "sdkmessageid_sdkmessageprocessingstep";
			public const string sdkmessageprocessingstepsecureconfigid_sdkmessageprocessingstep = "sdkmessageprocessingstepsecureconfigid_sdkmessageprocessingstep";
		}
		
		/// <summary>
		/// Default Constructor.
		/// </summary>
		[System.Diagnostics.DebuggerNonUserCode()]
		public SdkMessageProcessingStep() : 
				base(EntityLogicalName)
		{
		}
		
		public const string EntityLogicalName = "sdkmessageprocessingstep";
		
		public const string EntitySchemaName = "SdkMessageProcessingStep";
		
		public const string PrimaryIdAttribute = "sdkmessageprocessingstepid";
		
		public const string PrimaryNameAttribute = "name";
		
		public const string EntityLogicalCollectionName = "sdkmessageprocessingsteps";
		
		public const string EntitySetName = "sdkmessageprocessingsteps";
		
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
		/// Indicates whether the asynchronous system job is automatically deleted on completion.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("asyncautodelete")]
		public System.Nullable<bool> asyncautodelete
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<bool>>("asyncautodelete");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("asyncautodelete");
				this.SetAttributeValue("asyncautodelete", value);
				this.OnPropertyChanged("asyncautodelete");
			}
		}
		
		/// <summary>
		/// Identifies whether a SDK Message Processing Step type will be ReadOnly or Read Write. false - ReadWrite, true - ReadOnly 
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("canusereadonlyconnection")]
		public System.Nullable<bool> canusereadonlyconnection
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<bool>>("canusereadonlyconnection");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("canusereadonlyconnection");
				this.SetAttributeValue("canusereadonlyconnection", value);
				this.OnPropertyChanged("canusereadonlyconnection");
			}
		}
		
		/// <summary>
		/// For internal use only.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("category")]
		public string category
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("category");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("category");
				this.SetAttributeValue("category", value);
				this.OnPropertyChanged("category");
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
		/// Step-specific configuration for the plug-in type. Passed to the plug-in constructor at run time.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("configuration")]
		public string configuration
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("configuration");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("configuration");
				this.SetAttributeValue("configuration", value);
				this.OnPropertyChanged("configuration");
			}
		}
		
		/// <summary>
		/// Unique identifier of the user who created the SDK message processing step.
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
		/// Date and time when the SDK message processing step was created.
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
		/// Unique identifier of the delegate user who created the sdkmessageprocessingstep.
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
		/// Customization level of the SDK message processing step.
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
		/// Description of the SDK message processing step.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("description")]
		public string description
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("description");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("description");
				this.SetAttributeValue("description", value);
				this.OnPropertyChanged("description");
			}
		}
		
		/// <summary>
		/// EnablePluginProfiler
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("enablepluginprofiler")]
		public System.Nullable<bool> enablepluginprofiler
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<bool>>("enablepluginprofiler");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("enablepluginprofiler");
				this.SetAttributeValue("enablepluginprofiler", value);
				this.OnPropertyChanged("enablepluginprofiler");
			}
		}
		
		/// <summary>
		/// Configuration for sending pipeline events to the Event Expander service.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("eventexpander")]
		public string eventexpander
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("eventexpander");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("eventexpander");
				this.SetAttributeValue("eventexpander", value);
				this.OnPropertyChanged("eventexpander");
			}
		}
		
		/// <summary>
		/// Unique identifier of the associated event handler.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("eventhandler")]
		public Microsoft.Xrm.Sdk.EntityReference eventhandler
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("eventhandler");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("eventhandler");
				this.SetAttributeValue("eventhandler", value);
				this.OnPropertyChanged("eventhandler");
			}
		}
		
		/// <summary>
		/// Comma-separated list of attributes. If at least one of these attributes is modified, the plug-in should execute.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("filteringattributes")]
		public string filteringattributes
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("filteringattributes");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("filteringattributes");
				this.SetAttributeValue("filteringattributes", value);
				this.OnPropertyChanged("filteringattributes");
			}
		}
		
		/// <summary>
		/// Unique identifier of the user to impersonate context when step is executed.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("impersonatinguserid")]
		public Microsoft.Xrm.Sdk.EntityReference impersonatinguserid
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("impersonatinguserid");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("impersonatinguserid");
				this.SetAttributeValue("impersonatinguserid", value);
				this.OnPropertyChanged("impersonatinguserid");
			}
		}
		
		/// <summary>
		/// Version in which the form is introduced.
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
		/// Identifies if a plug-in should be executed from a parent pipeline, a child pipeline, or both.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("invocationsource")]
		[System.ObsoleteAttribute()]
		public Microsoft.Xrm.Sdk.OptionSetValue invocationsource
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("invocationsource");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("invocationsource");
				this.SetAttributeValue("invocationsource", value);
				this.OnPropertyChanged("invocationsource");
			}
		}
		
		/// <summary>
		/// Information that specifies whether this component can be customized.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("iscustomizable")]
		public Microsoft.Xrm.Sdk.BooleanManagedProperty iscustomizable
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.BooleanManagedProperty>("iscustomizable");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("iscustomizable");
				this.SetAttributeValue("iscustomizable", value);
				this.OnPropertyChanged("iscustomizable");
			}
		}
		
		/// <summary>
		/// Information that specifies whether this component should be hidden.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("ishidden")]
		public Microsoft.Xrm.Sdk.BooleanManagedProperty ishidden
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.BooleanManagedProperty>("ishidden");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("ishidden");
				this.SetAttributeValue("ishidden", value);
				this.OnPropertyChanged("ishidden");
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
		/// Run-time mode of execution, for example, synchronous or asynchronous.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("mode")]
		public virtual SdkMessageProcessingStep_mode? mode
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return ((SdkMessageProcessingStep_mode?)(EntityOptionSetEnum.GetEnum(this, "mode")));
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("mode");
				this.SetAttributeValue("mode", value.HasValue ? new Microsoft.Xrm.Sdk.OptionSetValue((int)value) : null);
				this.OnPropertyChanged("mode");
			}
		}
		
		/// <summary>
		/// Unique identifier of the user who last modified the SDK message processing step.
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
		/// Date and time when the SDK message processing step was last modified.
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
		/// Unique identifier of the delegate user who last modified the sdkmessageprocessingstep.
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
		/// Name of SdkMessage processing step.
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
		/// Unique identifier of the organization with which the SDK message processing step is associated.
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
		/// Unique identifier of the plug-in type associated with the step.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("plugintypeid")]
		[System.ObsoleteAttribute()]
		public Microsoft.Xrm.Sdk.EntityReference plugintypeid
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("plugintypeid");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("plugintypeid");
				this.SetAttributeValue("plugintypeid", value);
				this.OnPropertyChanged("plugintypeid");
			}
		}
		
		/// <summary>
		/// Unique identifier for powerfxrule associated with SdkMessageProcessingStep.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("powerfxruleid")]
		public Microsoft.Xrm.Sdk.EntityReference powerfxruleid
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("powerfxruleid");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("powerfxruleid");
				this.SetAttributeValue("powerfxruleid", value);
				this.OnPropertyChanged("powerfxruleid");
			}
		}
		
		/// <summary>
		/// Processing order within the stage.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("rank")]
		public System.Nullable<int> rank
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("rank");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("rank");
				this.SetAttributeValue("rank", value);
				this.OnPropertyChanged("rank");
			}
		}
		
		/// <summary>
		/// For internal use only. Holds miscellaneous properties related to runtime integration.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("runtimeintegrationproperties")]
		public string runtimeintegrationproperties
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("runtimeintegrationproperties");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("runtimeintegrationproperties");
				this.SetAttributeValue("runtimeintegrationproperties", value);
				this.OnPropertyChanged("runtimeintegrationproperties");
			}
		}
		
		/// <summary>
		/// Unique identifier of the SDK message filter.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("sdkmessagefilterid")]
		public Microsoft.Xrm.Sdk.EntityReference sdkmessagefilterid
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("sdkmessagefilterid");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("sdkmessagefilterid");
				this.SetAttributeValue("sdkmessagefilterid", value);
				this.OnPropertyChanged("sdkmessagefilterid");
			}
		}
		
		/// <summary>
		/// Unique identifier of the SDK message.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("sdkmessageid")]
		public Microsoft.Xrm.Sdk.EntityReference sdkmessageid
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("sdkmessageid");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("sdkmessageid");
				this.SetAttributeValue("sdkmessageid", value);
				this.OnPropertyChanged("sdkmessageid");
			}
		}
		
		/// <summary>
		/// Unique identifier of the SDK message processing step entity.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("sdkmessageprocessingstepid")]
		public System.Nullable<System.Guid> sdkmessageprocessingstepid
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<System.Guid>>("sdkmessageprocessingstepid");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("sdkmessageprocessingstepid");
				this.SetAttributeValue("sdkmessageprocessingstepid", value);
				if (value.HasValue)
				{
					base.Id = value.Value;
				}
				else
				{
					base.Id = System.Guid.Empty;
				}
				this.OnPropertyChanged("sdkmessageprocessingstepid");
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("sdkmessageprocessingstepid")]
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
				this.sdkmessageprocessingstepid = value;
			}
		}
		
		/// <summary>
		/// Unique identifier of the SDK message processing step.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("sdkmessageprocessingstepidunique")]
		public System.Nullable<System.Guid> sdkmessageprocessingstepidunique
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<System.Guid>>("sdkmessageprocessingstepidunique");
			}
		}
		
		/// <summary>
		/// Unique identifier of the Sdk message processing step secure configuration.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("sdkmessageprocessingstepsecureconfigid")]
		public Microsoft.Xrm.Sdk.EntityReference sdkmessageprocessingstepsecureconfigid
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("sdkmessageprocessingstepsecureconfigid");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("sdkmessageprocessingstepsecureconfigid");
				this.SetAttributeValue("sdkmessageprocessingstepsecureconfigid", value);
				this.OnPropertyChanged("sdkmessageprocessingstepsecureconfigid");
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
		/// Stage in the execution pipeline that the SDK message processing step is in.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("stage")]
		public virtual SdkMessageProcessingStep_stage? stage
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return ((SdkMessageProcessingStep_stage?)(EntityOptionSetEnum.GetEnum(this, "stage")));
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("stage");
				this.SetAttributeValue("stage", value.HasValue ? new Microsoft.Xrm.Sdk.OptionSetValue((int)value) : null);
				this.OnPropertyChanged("stage");
			}
		}
		
		/// <summary>
		/// Status of the SDK message processing step.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("statecode")]
		public System.Nullable<Pg.DataverseTags.Shared.Model.SdkMessageProcessingStepState> statecode
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				Microsoft.Xrm.Sdk.OptionSetValue optionSet = this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("statecode");
				if ((optionSet != null))
				{
					return ((Pg.DataverseTags.Shared.Model.SdkMessageProcessingStepState)(System.Enum.ToObject(typeof(Pg.DataverseTags.Shared.Model.SdkMessageProcessingStepState), optionSet.Value)));
				}
				else
				{
					return null;
				}
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("statecode");
				if ((value == null))
				{
					this.SetAttributeValue("statecode", null);
				}
				else
				{
					this.SetAttributeValue("statecode", new Microsoft.Xrm.Sdk.OptionSetValue(((int)(value))));
				}
				this.OnPropertyChanged("statecode");
			}
		}
		
		/// <summary>
		/// Reason for the status of the SDK message processing step.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("statuscode")]
		public virtual SdkMessageProcessingStep_StatusCode? statuscode
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return ((SdkMessageProcessingStep_StatusCode?)(EntityOptionSetEnum.GetEnum(this, "statuscode")));
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("statuscode");
				this.SetAttributeValue("statuscode", value.HasValue ? new Microsoft.Xrm.Sdk.OptionSetValue((int)value) : null);
				this.OnPropertyChanged("statuscode");
			}
		}
		
		/// <summary>
		/// Deployment that the SDK message processing step should be executed on; server, client, or both.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("supporteddeployment")]
		public virtual SdkMessageProcessingStep_supporteddeployment? supporteddeployment
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return ((SdkMessageProcessingStep_supporteddeployment?)(EntityOptionSetEnum.GetEnum(this, "supporteddeployment")));
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("supporteddeployment");
				this.SetAttributeValue("supporteddeployment", value.HasValue ? new Microsoft.Xrm.Sdk.OptionSetValue((int)value) : null);
				this.OnPropertyChanged("supporteddeployment");
			}
		}
		
		/// <summary>
		/// Number that identifies a specific revision of the SDK message processing step. 
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
		/// 1:N sdkmessageprocessingstepid_sdkmessageprocessingstepimage
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("sdkmessageprocessingstepid_sdkmessageprocessingstepimage")]
		public System.Collections.Generic.IEnumerable<Pg.DataverseTags.Shared.Model.SdkMessageProcessingStepImage> sdkmessageprocessingstepid_sdkmessageprocessingstepimage
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<Pg.DataverseTags.Shared.Model.SdkMessageProcessingStepImage>("sdkmessageprocessingstepid_sdkmessageprocessingstepimage", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("sdkmessageprocessingstepid_sdkmessageprocessingstepimage");
				this.SetRelatedEntities<Pg.DataverseTags.Shared.Model.SdkMessageProcessingStepImage>("sdkmessageprocessingstepid_sdkmessageprocessingstepimage", null, value);
				this.OnPropertyChanged("sdkmessageprocessingstepid_sdkmessageprocessingstepimage");
			}
		}
		
		/// <summary>
		/// N:1 plugintype_sdkmessageprocessingstep
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("eventhandler")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("plugintype_sdkmessageprocessingstep")]
		public Pg.DataverseTags.Shared.Model.PluginType plugintype_sdkmessageprocessingstep
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<Pg.DataverseTags.Shared.Model.PluginType>("plugintype_sdkmessageprocessingstep", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("plugintype_sdkmessageprocessingstep");
				this.SetRelatedEntity<Pg.DataverseTags.Shared.Model.PluginType>("plugintype_sdkmessageprocessingstep", null, value);
				this.OnPropertyChanged("plugintype_sdkmessageprocessingstep");
			}
		}
		
		/// <summary>
		/// N:1 plugintypeid_sdkmessageprocessingstep
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("plugintypeid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("plugintypeid_sdkmessageprocessingstep")]
		public Pg.DataverseTags.Shared.Model.PluginType plugintypeid_sdkmessageprocessingstep
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<Pg.DataverseTags.Shared.Model.PluginType>("plugintypeid_sdkmessageprocessingstep", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("plugintypeid_sdkmessageprocessingstep");
				this.SetRelatedEntity<Pg.DataverseTags.Shared.Model.PluginType>("plugintypeid_sdkmessageprocessingstep", null, value);
				this.OnPropertyChanged("plugintypeid_sdkmessageprocessingstep");
			}
		}
		
		/// <summary>
		/// N:1 sdkmessagefilterid_sdkmessageprocessingstep
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("sdkmessagefilterid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("sdkmessagefilterid_sdkmessageprocessingstep")]
		public Pg.DataverseTags.Shared.Model.SdkMessageFilter sdkmessagefilterid_sdkmessageprocessingstep
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<Pg.DataverseTags.Shared.Model.SdkMessageFilter>("sdkmessagefilterid_sdkmessageprocessingstep", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("sdkmessagefilterid_sdkmessageprocessingstep");
				this.SetRelatedEntity<Pg.DataverseTags.Shared.Model.SdkMessageFilter>("sdkmessagefilterid_sdkmessageprocessingstep", null, value);
				this.OnPropertyChanged("sdkmessagefilterid_sdkmessageprocessingstep");
			}
		}
		
		/// <summary>
		/// N:1 sdkmessageid_sdkmessageprocessingstep
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("sdkmessageid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("sdkmessageid_sdkmessageprocessingstep")]
		public Pg.DataverseTags.Shared.Model.SdkMessage sdkmessageid_sdkmessageprocessingstep
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<Pg.DataverseTags.Shared.Model.SdkMessage>("sdkmessageid_sdkmessageprocessingstep", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("sdkmessageid_sdkmessageprocessingstep");
				this.SetRelatedEntity<Pg.DataverseTags.Shared.Model.SdkMessage>("sdkmessageid_sdkmessageprocessingstep", null, value);
				this.OnPropertyChanged("sdkmessageid_sdkmessageprocessingstep");
			}
		}
		
		/// <summary>
		/// N:1 sdkmessageprocessingstepsecureconfigid_sdkmessageprocessingstep
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("sdkmessageprocessingstepsecureconfigid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("sdkmessageprocessingstepsecureconfigid_sdkmessageprocessingstep")]
		public Pg.DataverseTags.Shared.Model.SdkMessageProcessingStepSecureConfig sdkmessageprocessingstepsecureconfigid_sdkmessageprocessingstep
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<Pg.DataverseTags.Shared.Model.SdkMessageProcessingStepSecureConfig>("sdkmessageprocessingstepsecureconfigid_sdkmessageprocessingstep", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("sdkmessageprocessingstepsecureconfigid_sdkmessageprocessingstep");
				this.SetRelatedEntity<Pg.DataverseTags.Shared.Model.SdkMessageProcessingStepSecureConfig>("sdkmessageprocessingstepsecureconfigid_sdkmessageprocessingstep", null, value);
				this.OnPropertyChanged("sdkmessageprocessingstepsecureconfigid_sdkmessageprocessingstep");
			}
		}
		
		/// <summary>
		/// Constructor for populating via LINQ queries given a LINQ anonymous type
		/// <param name="anonymousType">LINQ anonymous type.</param>
		/// </summary>
		[System.Diagnostics.DebuggerNonUserCode()]
		public SdkMessageProcessingStep(object anonymousType) : 
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
                        Attributes["sdkmessageprocessingstepid"] = base.Id;
                        break;
                    case "sdkmessageprocessingstepid":
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