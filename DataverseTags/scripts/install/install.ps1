
param ([Parameter(Mandatory)]$url, [Parameter(Mandatory)]$appId, [Parameter(Mandatory)]$secret, [Parameter(Mandatory)]$tenantId)

write-host "PowerShell Command Line toos are required to successfully run this script. ";
write-host "If you don't have them installed - please do it from the following MSI file: ";
write-host "https://aka.ms/PowerAppsCLI";

write-host "Script run with the following parameters:";
write-host "Url: $url";
write-host "AppId: $appId";
write-host "Secret: $secret";
write-host "TenantId: $tenantId";

write-host "Generating temporary authentication profile name...";
$controlsSolutionPath = ".\solutions\DataverseTagsControls.zip";
$customizationSolutionPath = ".\solutions\DataverseTags_managed.zip"; 
$name = (-join ((65..90) + (97..122) | Get-Random -Count 20 | % {[char]$_})) #Generate random 20-characters string
write-host "Temporary authentication profile name: $name";
write-host "Creating authentication profile: $name";
pac auth create --url $url --name $name --applicationId $appId --clientSecret $secret --tenant $tenantId
write-host "Authentication profile $name created ";
pac auth select --name $name
write-host "Authentication profile $name selected";
write-host "Importing solution $controlsSolutionPath ...";
pac solution import --path $controlsSolutionPath
write-host "Solution $controlsSolutionPath imported";
write-host "Importing solution $customizationSolutionPath  ...";
pac solution import --path $customizationSolutionPath 
write-host "Solution $customizationSolutionPath imported";
write-host "Registering plugins and steps..."
.\Release\Pg.DataverseTags.Plugins.StepsRegistrator.exe -url:$url -appId:$appId -clientSecret:$secret
write-host "Plugins and steps registered"
write-host "Deleting authentication profile $name";
pac auth delete --name $name
write-host "Deleting authentication $name profile deleted";