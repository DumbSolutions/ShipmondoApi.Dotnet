// Name: Patch open api document
// Date: 2023-06-21
// Description:
//   1. Change description of openapi document so that
//      we dont advertise this package as being official.
//   2. Modify a specific case where enum isn't generated.
//      Appears to be a bug in OpenAPI:
//      https://github.com/OpenAPITools/openapi-generator/issues/2360
//   3. Fix ReceiverRequest and ShipmentReceiver date field isn't nullable
const { readFileSync, writeFileSync } = require("fs");

const file = process.argv[2];
if (file == null || file == "") {
    console.log("missing filename");
    return;
}

const content = readFileSync(file, "utf8");
const json = JSON.parse(content);
json.info.description = "A unofficial thirdparty library for shipmondo api for dotnet";
delete json.info.contact;

delete json.components.schemas.staff_account.properties.permissions.enum;

json.components.schemas.ReceiverRequest.properties.date.nullable = true;
json.components.schemas.ShipmentReceiver.properties.date.nullable = true;

writeFileSync(file, JSON.stringify(json), "utf-8");
