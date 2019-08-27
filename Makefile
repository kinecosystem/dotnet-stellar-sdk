build:
	dotnet build

pack:
	# todo

test:
	# Test, normal verbositry, collect cov, output as opencover, exclude the auto-generated xdr files
	dotnet test -v n ./kin-base-test -p:CollectCoverage=true -p:CoverletOutputFormat=opencover -p:Exclude=[*]kin_base.xdr.*

upload:
	# todo

clean:
	rm -rf */bin */obj

