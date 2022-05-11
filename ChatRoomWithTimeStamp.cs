namespace ChatGroup;

public class ChatRoomWithTimeStamp : IChatRoom
{
    private readonly IChatRoom _chatRoom;

    public ChatRoomWithTimeStamp(IChatRoom chatRoom)
    {
        _chatRoom = chatRoom;
    }

    public void RegisterPatient(Patient patient)
    {
        _chatRoom.RegisterPatient(patient);
    }

    public void SendMessage(Patient patient, string message)
    {
        _chatRoom.SendMessage(patient, DateTime.Now + " " + message);
    }
}