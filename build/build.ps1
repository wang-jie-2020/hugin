Write-Host "Start Building"

# COMMON PATHS

$buildFolder = (Get-Item -Path "./" -Verbose).FullName
$slnFolder = Join-Path $buildFolder "../"
$outputFolder = Join-Path $buildFolder "outputs"
$identityFolder = Join-Path $slnFolder "host/LG.NetCore.IdentityServer.Host"
$platformFolder = Join-Path $slnFolder "host/LG.NetCore.Platform.Host"
$terminalFolder = Join-Path $slnFolder "host/LG.NetCore.Terminal.Host"

## CLEAR ######################################################################

Remove-Item $outputFolder -Force -Recurse -ErrorAction Ignore
New-Item -Path $outputFolder -ItemType Directory

## RESTORE NUGET PACKAGES #####################################################

Set-Location $slnFolder
dotnet restore

## PUBLISH HOST PROJECT ###################################################

Set-Location $identityFolder
dotnet publish --configuration "Release" --output (Join-Path $outputFolder "ids4")

Set-Location $platformFolder
dotnet publish --configuration "Release" --output (Join-Path $outputFolder "platform")

Set-Location $terminalFolder
dotnet publish --configuration "Release" --output (Join-Path $outputFolder "terminal")

Write-Host "dotnet Publish Success ....."

## FINALIZE ###################################################################

Set-Location $outputFolder