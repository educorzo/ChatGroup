using ChatGroup;

Console.WriteLine("---------");
var chatRoom = new ChatRoom();
var chatRoomWithTimeStamp = new ChatRoomWithTimeStamp(chatRoom);
var chatRoomWithSender = new ChatRoomWithSender(chatRoomWithTimeStamp);

var robert = new Patient(chatRoomWithSender, "Robert");
var john = new Patient(chatRoomWithSender, "John");

chatRoomWithSender.RegisterPatient(robert);
chatRoomWithSender.RegisterPatient(john);
Console.WriteLine("---------");

robert.SendMessage("Time to do some exercise!");
john.SendMessage("Vaccines rules!");