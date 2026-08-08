param(
    [Parameter(Mandatory = $true)][string]$Name
)

$handlerPath = "./Ian.Application/RequestHandling/RequestHandler.cs"
$marker = "                // --- NEW-CASE-MARKER ---"

$existingContent = Get-Content $handlerPath -Raw

if ($existingContent -match "case\s+${Name}Request\s+") {
    Write-Host "A switch case for '${Name}Request' already exists in RequestHandler.cs skipping insertion." -ForegroundColor Yellow
    Write-Host "Still running dotnet new in case files were deleted/regenerated..."
}

# 1. Generate the three files via dotnet new
dotnet new action --name $Name

# 2. Insert the new switch case into RequestHandler.cs, unless it's already there
if ($existingContent -notmatch "case\s+${Name}Request\s+") {
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

    (Get-Content $handlerPath -Raw) -replace [regex]::Escape($marker), $newCase | Set-Content $handlerPath
    Write-Host "Generated $Name action and updated RequestHandler.cs" -ForegroundColor Green
}
else {
    Write-Host "Generated $Name files; RequestHandler.cs left untouched (case already present)." -ForegroundColor Green
}