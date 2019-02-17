param(
	[String]$output
)

$currDir = Get-Location
$fullPath = Join-Path $currDir $output

# Create solution
dotnet new sln -o $output

# Create classlib project
$projDir = Join-Path $fullPath $output 
dotnet new classlib -o $projDir

# Create NUnit test project
$testsDir = $output + ".UnitTests"
$testsDir = Join-Path $fullPath $testsDir
dotnet new nunit -o $testsDir

# Add references
cd $fullPath
dotnet sln add $projDir
dotnet sln add $testsDir

cd $testsDir
dotnet add reference $projDir


cd $currDir