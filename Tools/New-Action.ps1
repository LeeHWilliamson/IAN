param(
    [Parameter(Mandatory = $true)][string]$Name
)

$requestHandlerPath = "./Ian.Application/RequestHandling/RequestHandler.cs"
$resultHandlerPath = "./Ian.Application/RequestHandling/ResultHandler.cs"
$marker = "                // --- NEW-CASE-MARKER ---"

$requestContent = Get-Content $requestHandlerPath -Raw
$resultContent = Get-Content $resultHandlerPath -Raw

if ($requestContent -match "case\s+${Name}Result\s+") {
    Write-Host "A switch case for '${Name}Result' already exists in ResultHandler.cs skipping insertion." -ForegroundColor Yellow
    Write-Host "Still running dotnet new in case files were deleted/regenerated..."
}

if ($resultContent -match "case\s+${Name}Request\s+") {
    Write-Host "A switch case for '${Name}Request' already exists in RequestHandler.cs skipping insertion." -ForegroundColor Yellow
    Write-Host "Still running dotnet new in case files were deleted/regenerated..."
}

# 1. Generate the three files via dotnet new
dotnet new action --name $Name

# 2. Insert the new switch case into RequestHandler.cs, unless it's already there
if ($requestContent -notmatch "case\s+${Name}Request\s+") {
    $varName = "${Name}Request_"
    $lines = @(
        "                case ${Name}Request ${varName}:",
        "                    {",
        "                        _results.Add(${Name}Rules.Evaluate(${varName}));",
        "                        break;",
        "                    }",
        $marker
    )
    $newCase = ($lines -join "`r`n")

    (Get-Content $requestHandlerPath -Raw) -replace [regex]::Escape($marker), $newCase | Set-Content $requestHandlerPath
    Write-Host "Generated $Name action and updated RequestHandler.cs" -ForegroundColor Green
}
else {
    Write-Host "Generated $Name files; RequestHandler.cs left untouched (case already present)." -ForegroundColor Green
}

# 3. Insert the new result into ResultHander.cs, unless it's already there
if ($resultContent -notmatch "case\s+${Name}Result\s+") {
    $varName = "${Name}Result_"
    $lines = @(
        "                case ${Name}Result ${varName}:",
        "                    {",
        "                        // handle the results",
        "                        break;",
        "                    }",
        $marker
    )
    $newCase = ($lines -join "`r`n")

    (Get-Content $resultHandlerPath -Raw) -replace [regex]::Escape($marker), $newCase | Set-Content $resultHandlerPath
    Write-Host "Generated $Name action and updated ResultHandler.cs" -ForegroundColor Green
}
else {
    Write-Host "Generated $Name files; ResultHandler.cs left untouched (case already present)." -ForegroundColor Green
}