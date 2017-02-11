const fs = require("fs");

let content = "This is just some random test text, no woriess";
fs.writeFileSync("../testingFileWriter.md", content, "utf8");