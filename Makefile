clean:
	-find -type d -name bin -exec rm -rf {} \;
	-find -type d -name obj -exec rm -rf {} \;

compile: clean
	nuget restore example.sln
	msbuild /p:TargetFrameworkVersion="v4.5" /p:Configuration=Release example.sln

test:
	nuget install NUnit.Runners -Version 3.11.1 -OutputDirectory tools
	mono ./tools/NUnit.Console.3.11.1/tools/nunit3-console.exe -workers 1 `(find Tests -name *Tests.dll | grep -v obj/Release)`

coverageconfig:
	./ContinuousIntegration/Build/generateCoverageConfig.sh > ./coverageConfig.json

instrument: coverageconfig
	mono ./tools/SharpCover/SharpCover.exe instrument ./coverageConfig.json

coverage: compile instrument test
	-mono ./tools/SharpCover/SharpCover.exe check
