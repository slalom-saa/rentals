cd $PSScriptRoot

cd ..

foreach($item in Get-ChildItem -Filter '*.sln')
{
    . "C:\Source\Stacks\Documentation\src\Slalom.Stacks.Documentation.Word\bin\Debug\net461\win10-x64\Slalom.Stacks.Documentation.Word.exe" $item.FullName "it.docx"
}

