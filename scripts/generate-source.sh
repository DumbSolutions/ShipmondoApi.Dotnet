version="1.0.0";
file_path="src/ShipmondoApi.Dotnet/ShipmondoApi.Dotnet.csproj"
if test -f "$file_path"; then
    # Read each line of the file
    while IFS= read -r line; do
    # Check if the line has version tag
    if [[ $line == *"<Version>"*"</Version>" ]]; then
        # Extract the version string between the tags
        version=$(echo "$line" | sed -n 's/.*<Version>\(.*\)<\/Version>.*/\1/p')
    fi
    done < "$file_path"
fi

npx --yes @openapitools/openapi-generator-cli generate -i elements.json \
  -g csharp-netcore --additional-properties=library=restsharp \
  --git-host=github.com \
  --git-user-id=DumbSolutions \
  --git-repo-id=ShipmondoApi.Dotnet \
  --additional-properties=targetFramework=netstandard2.0 \
  --additional-properties=optionalAssemblyInfo=false \
  "--additional-properties=packageGuid={788F91F2-24A9-4510-8ABE-07C7492245DC}" \
  --additional-properties=packageTitle=ShipmondoApi.Dotnet \
  --additional-properties=packageAuthors=DumbSolutions \
  --additional-properties=packageCompany=DumbSolutions \
  "--additional-properties=packageDescription='A unofficial thirdparty library for shipmondo api for dotnet'" \
  "--additional-properties=packageVersion='$version'" \
  "--additional-properties=httpUserAgent='DumbSolutions.ShipmondoApi.Dotnet/$version'" \
  --additional-properties=packageName=ShipmondoApi.Dotnet && \
  node patch-source-files.js