let csvToJson = require('convert-csv-to-json');
 
let fileInputName = 'train.csv'; 
let fileOutputName = 'Full_data.json';
 
csvToJson.fieldDelimiter(',').generateJsonFileFromCsv(fileInputName,fileOutputName);