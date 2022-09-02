// See https://aka.ms/new-console-template for more information
using Strategy;

Console.WriteLine("Hello, World!");

var chatclient = new ChatClient();

chatclient.send("test", new DesEncryptionAlgorithm());
chatclient.send("test", new AesEncryptionAlgorithm());