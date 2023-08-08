# Introduction 
DataverseTags is Datavese solutions set making tagging Datavese records from Power Platform Model Driven App very simple.  
1. Default Tags database.
2. Adding default and user-defined tags on the model-driven app form
   
   ![alt text](https://raw.githubusercontent.com/gashupl/dataverse-toolkit/main/DataverseTags/docs/images/01.png?raw=true)
   
4. Searching records by tag(s). 

# Installation
1.	Download and open latest release of DataverseTags
2.	Import DataverseTagsControls.zip managed solution into your Dataverse environment.
3.	Import DataverseTags_managed.zip solution into your Dataverse environment.
   
# Getting Started
1. Open the **Tags Management** mobile-driven app and go to the Tags list inside the Administration section. This is the place where you may add default tags, which will be suggested on every record with tag functionality configured. This is an optional step, so if you don't want to configure default tags, just leave it as is.
2. For using tags functionality on the specific form, open it inside Power App Maker Studio and select DataverseTags as a default component on the text column, which will be used for storing information about used tags.
   
   ![alt text](https://raw.githubusercontent.com/gashupl/dataverse-toolkit/main/DataverseTags/docs/images/02.png?raw=true)

3. For searching records by tags, just add the previously mentioned column as a searchable one for Power Platform model-driven apps search functionalities.
