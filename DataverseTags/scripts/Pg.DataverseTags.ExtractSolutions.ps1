Import-Module Microsoft.Xrm.Data.Powershell

Write-Output "setting valid TLS version..."
[Net.ServicePointManager]::SecurityProtocol = [Net.SecurityProtocolType]::Tls12

$managedSolutionName = "DataverseTags_managed"
$unmanagedSolutionName = "DataverseTags"
$solution1FileName = "DataverseTags.zip"
$exportLocation = "..\solutions"

Write-Output "Creating solution folder if not exists..."
If(!(test-path $exportLocation))
{
       New-Item -ItemType Directory -Force -Path $exportLocation
 }

Write-Output "exporting managed customization file..."

$connection = Get-CrmConnection -InteractiveMode -MaxCrmConnectionTimeOutMinutes 60

Export-CrmSolution -SolutionName $unmanagedSolutionName -SolutionFilePath $exportLocation -SolutionZipFileName $solution1FileName  -Managed -conn $connection

Write-Output "Extracting customization file and removing downloaded zip archive..."
..\tools\Sdk\CoreTools\SolutionPackager.exe `
/action:extract `
/folder:$exportLocation\$managedSolutionName\src  `
/zipfile:$exportLocation\$solution1FileName `
/allowdelete:yes `
# /map: ..\src\Pg.DataverseTags\Infrastructure\Resources\solution-map.xml 

Write-output "extraction process completed."

Write-Output "Deleting extracted NUGET package file ..."
Remove-Item $exportLocation\$managedSolutionName\src\pluginpackages\pg_Pg.DataverseTags.Plugins\package\*.*

Write-Output "Deleting solution's file..."
Remove-Item $exportLocation\$solution1FileName
Write-Output "Operation completed."


Write-Output "exporting unmanaged customization file..."


Export-CrmSolution -SolutionName $unmanagedSolutionName -SolutionFilePath $exportLocation -SolutionZipFileName $solution1FileName -conn $connection

Write-Output "Extracting customization file and removing downloaded zip archive..."
..\tools\Sdk\CoreTools\SolutionPackager.exe `
/action:extract `
/folder:$exportLocation\$unmanagedSolutionName\src  `
/zipfile:$exportLocation\$solution1FileName `
/allowdelete:yes `
# /map: ..\src\Pg.DataverseTags\Infrastructure\Resources\solution-map.xml 

Write-output "extraction process completed."

Write-Output "Deleting extracted NUGET package file ..."
Remove-Item $exportLocation\$unmanagedSolutionName\src\pluginpackages\pg_Pg.DataverseTags.Plugins\package\*.*

Write-Output "Deleting solution's file..."
Remove-Item $exportLocation\$solution1FileName

Write-Output "Operation completed."




