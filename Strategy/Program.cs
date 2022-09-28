
using Strategy;

var chatclient = new ChatClient();

chatclient.send("test", new DesEncryptionAlgorithm());
chatclient.send("test", new AesEncryptionAlgorithm());