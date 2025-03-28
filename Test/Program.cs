using Lessons.Adapter;

var target = new Target();
var client = new Client();
var adapter = new Adapter();

client.Request(target);
client.Request(adapter);