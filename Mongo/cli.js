var MongoClient = require('mongodb').MongoClient;
var assert = require('assert');
var ObjectId = require('mongodb').ObjectID;

let csvToJson = require('convert-csv-to-json');
let fileInputName = 'Crime_Rates_By_Region.csv'; 
let fileOutputName = 'myOutputFile.json';
 
jsona = csvToJson.fieldDelimiter(',').formatValueByType().getJsonFromCsv(fileInputName);
for(i  = 0 ; i < jsona.length ; i++){
	//console.log(jsona[i]["Location"])
	jsona[i]["Score"] = parseInt(jsona[i]["Score"])
	//console.log(jsona[i])
}

var uri = "mongodb://kush:test@ds036577.mlab.com:36577/safedb"
MongoClient.connect(uri, function(err, db) {
  if (err) throw err;
  db.createCollection("Region_Data", function(err, res) {
    if (err) throw err;
    console.log("Collection created!");
    db.close()
  });
});

