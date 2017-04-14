cd $PSScriptRoot

if (!(Test-Path "$PSScriptRoot\Document.exe")) {
    $url = "https://github.com/slalom-saa/stacks/raw/develop/assets/Document.exe"
    $output = "$PSScriptRoot\Document.exe"
    (New-Object System.Net.WebClient).DownloadFile($url, $output)
}
if (!(Test-Path "$PSScriptRoot\Microsoft.Build.dll")) {
    $url = "https://github.com/slalom-saa/stacks/raw/develop/assets/Microsoft.Build.dll"
    $output = "$PSScriptRoot\Microsoft.Build.dll"
    (New-Object System.Net.WebClient).DownloadFile($url, $output)
}

foreach($item in Get-ChildItem -Path ".." -Filter '*.sln')
{
    . "$PSScriptRoot\Document.exe" $item.FullName "document.docx"
}

