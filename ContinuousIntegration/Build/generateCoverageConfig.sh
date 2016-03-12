ASSEMBLIES=`find Tests -type f -name Codecov.Example.*.dll | grep -v /obj/ | grep -v Tests.dll | perl -e '@in=grep(s/\n$//, <>); print "[\"".join("\", \"", @in)."\"],\n";'`
echo "{"
echo "  \"assemblies\": ${ASSEMBLIES}" 
echo "  \"typeInclude\": \"Codecov.Example.*\"," 
echo "  \"typeExclude\": \"Codecov.Example.*Tests*\""
echo "}"
