var MongoClient = require('mongodb').MongoClient;
var assert = require('assert');
var ObjectId = require('mongodb').ObjectID;

let csvToJson = require('convert-csv-to-json');
let fileInputName = 'new.csv'; 
let fileOutputName = 'myOutputFile.json';
 
jsona = csvToJson.fieldDelimiter(',').formatValueByType().getJsonFromCsv(fileInputName);
for(i  = 0 ; i < jsona.length ; i++){
	//console.log(jsona[i]["Location"])
	jsona[i]["Score"] = parseInt(jsona[i]["Score"])
	//console.log(jsona[i])
}


//console.log(jsona)

var uri = "mongodb://kush:test@ds036577.mlab.com:36577/safedb"
MongoClient.connect(uri, function(err, db) {
  //db.collection("Region_Data3").createIndex({"Location" : 1})

  db.collection("Region_Data5").insertMany(jsona, function(err, res) {
    if (err) throw err;
    console.log("1 document inserted");
    db.close();
  });
  
});

