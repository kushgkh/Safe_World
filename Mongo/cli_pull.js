
var MongoClient = require('mongodb').MongoClient;
var assert = require('assert');
var ObjectId = require('mongodb').ObjectID;
var uri = "mongodb://kush:test@ds036577.mlab.com:36577/safedb"
//var query = { Location: element};
MongoClient.connect(uri, function(err, db) {
	db.collection("Region_Data4").find().toArray().then(function(data) {

		function get_Score(element)
		{
			//console.log(data)
			return data[element]["Score"]
		}
		console.log(get_Score(22930))
		function map_points(lat, lon, X_DIVS=200, Y_DIVS=200){ //<<---- X and Y DIVS are set to 200
			
			var x_coord = Math.floor((lon + 122.55) / (0.2/ X_DIVS))
			var y_coord = Math.floor((lat - 37.65) / (0.2/ Y_DIVS))
			console.log(lon)
			var combined = x_coord + y_coord * X_DIVS
			return combined
		}
		console.log(map_points(37.7745985956747 , -122.425891675136 ))
		
  	})
});

