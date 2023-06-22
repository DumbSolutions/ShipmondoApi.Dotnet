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
  --additional-properties=packageName=ShipmondoApi.Dotnet && \
  node patch-source-files.js