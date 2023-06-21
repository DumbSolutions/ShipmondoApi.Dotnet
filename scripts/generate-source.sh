npx --yes @openapitools/openapi-generator-cli generate -i elements.json \
  -g csharp-netcore --additional-properties=library=restsharp \
  --additional-properties=packageName=DumbSolutions.ShipmondoApi \
  --additional-properties=targetFramework=netstandard2.0 \
  --additional-properties=optionalAssemblyInfo=false \
  "--additional-properties=packageGuid={788F91F2-24A9-4510-8ABE-07C7492245DC}" \
  --additional-properties=packageName=ShipmondoApi.Dotnet && \
  node patch-source-files.js