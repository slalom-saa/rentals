cd $PSScriptRoot

if (!(Test-Path "$PSScriptRoot\Document.exe")) {
    $url = "https://slalomstacks.blob.core.windows.net/public/Document.exe"
    $output = "$PSScriptRoot\Document.exe"
    (New-Object System.Net.WebClient).DownloadFile($url, $output)
}
if (!(Test-Path "$PSScriptRoot\Microsoft.Build.dll")) {
    $url = "https://slalomstacks.blob.core.windows.net/public/Microsoft.Build.dll"
    $output = "$PSScriptRoot\Microsoft.Build.dll"
    (New-Object System.Net.WebClient).DownloadFile($url, $output)
}
if (!(Test-Path "$PSScriptRoot\Microsoft.Build.Framework.dll")) {
    $url = "https://slalomstacks.blob.core.windows.net/public/Microsoft.Build.Framework.dll"
    $output = "$PSScriptRoot\Microsoft.Build.Framework.dll"
    (New-Object System.Net.WebClient).DownloadFile($url, $output)
}
if (!(Test-Path "$PSScriptRoot\Microsoft.Build.Tasks.Core.dll")) {
    $url = "https://slalomstacks.blob.core.windows.net/public/Microsoft.Build.Tasks.Core.dll"
    $output = "$PSScriptRoot\Microsoft.Build.Tasks.Core.dll"
    (New-Object System.Net.WebClient).DownloadFile($url, $output)
}
if (!(Test-Path "$PSScriptRoot\Microsoft.Build.Utilities.Core.dll")) {
    $url = "https://slalomstacks.blob.core.windows.net/public/Microsoft.Build.Utilities.Core.dll"
    $output = "$PSScriptRoot\Microsoft.Build.Utilities.Core.dll"
    (New-Object System.Net.WebClient).DownloadFile($url, $output)
}


foreach($item in Get-ChildItem -Path ".." -Filter '*.sln')
{
    $name = $item.FullName
    . "$PSScriptRoot\Document.exe" "$name" "document.docx"
}