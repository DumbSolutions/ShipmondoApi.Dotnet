// Name: Fix broken openapi json file with syntax errors
// Date: 2023-06-21
// Description:
//   For some reason the openapi json from shipmondo has a few syntax errors.
//   This script is made to fix those errors to make the json valid. 
//   I have no idea why this was necessary.
const { readFileSync, writeFileSync } = require("fs");

const file = process.argv[2];
if (file == null || file == "") {
    console.log("missing filename");
    return;
}

const content = readFileSync(file, "utf8");

let result = "";
let insideString = false;
for (var i = 0; i < content.length; i++) {
    if (content[i] == "\"" && content[i - 1] !== "\\") {
        insideString = !insideString;
        result += content[i];
        continue;
    }
    if (content[i] === "\n") {
        if (insideString) {
            result += "\\n";
        }
        continue;
    }
    if (content[i] === " " && !insideString) {
        continue;
    }
    result += content[i];
}

result = result.replace(/,(\}|\])/gi, "$1");

function findUndefinedValue(code) {
    try {
        new Function(`return ${code};`)();
    }
    catch (err) {
        if (err instanceof ReferenceError) {
            const match = err.message.match(/^(.*) is not defined/);
            if (match != null) {
                return match[1];
            }
        }
        throw err;
    }

}
let undefinedValue;
while ((undefinedValue = findUndefinedValue(result)) != null) {
    console.log("replacing " + undefinedValue);
    const regex = new RegExp("([^\"])" + undefinedValue + "([^\"])", "g");
    console.log(regex);
    const newResult = result.replace(regex, "$1\"" + undefinedValue + "\"$2");
    if (newResult === result) {
        throw new Error("Didn't replace anything");
    }
    result = newResult;
}
console.log();
writeFileSync(file, result, "utf-8");
