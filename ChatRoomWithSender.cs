namespace ChatGroup;

public class ChatRoomWithSender : IChatRoom
{
    private readonly IChatRoom _chatRoom;

    public ChatRoomWithSender(IChatRoom chatRoom)
    {
        _chatRoom = chatRoom;
    }

    public void RegisterPatient(Patient patient)
    {
        _chatRoom.RegisterPatient(patient);
    }

    public void SendMessage(Patient patient, string message)
    {
        _chatRoom.SendMessage(patient, "-" + patient.GetName() + ": " + message);
    }
}