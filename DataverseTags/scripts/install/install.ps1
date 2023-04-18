
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
$name = New-GUID;
write-host "Temporary authentication profile name: $name";
write-host "Creating authentication profile: $name";
pac auth create --url $url --name $name --applicationId $appId --clientSecret $secret --tenant $tenantId
pac auth select --name $name
write-host "Authentication profile $name selected and updated";


write-host "Deleting authentication profile $name";
pac auth delete --name $name
write-host "Deleting authentication $name profile deleted";