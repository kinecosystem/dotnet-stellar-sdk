build:
	dotnet build

build-release:
	dotnet build -c Release

pack:
	dotnet pack -c Release

test:
	# Test, normal verbositry, collect cov, output as opencover, exclude the auto-generated xdr files
	dotnet test ./kin-base-test -p:CollectCoverage=true -p:CoverletOutputFormat=opencover -p:Exclude=[*]kin_base.xdr.*

upload:
	@dotnet nuget push kin-base/bin/Release/kin-base*.nupkg -k $(KEY) -s https://api.nuget.org/v3/index.json

clean:
	rm -rf */bin */obj

