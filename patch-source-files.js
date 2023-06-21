// Fix some compiler issues

const { readFileSync, writeFileSync } = require("fs");

{
    // File: src/ShipmondoApi.Dotnet/Api/ServicePointsApi.cs
    // Issue: error CS0104: 'ServicePoint' is an ambiguous reference between 'ShipmondoApi.Dotnet.Model.ServicePoint' and 'System.Net.ServicePoint'
    // Solution: Remove line "using System.Net;" from the file. We dont use System.Net for anything anyway.
    const path = "src/ShipmondoApi.Dotnet/Api/ServicePointsApi.cs";
    let content = readFileSync(path, "utf8");
    content = content.replace(/^using System\.Net;$(\r)?\n/gm, "");
    writeFileSync(path, content, "utf-8");
}