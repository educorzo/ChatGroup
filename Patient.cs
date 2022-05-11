namespace ChatGroup;

public class Patient
{
    private readonly string _name;
    private readonly IChatRoom _chatRoom;

    public Patient(IChatRoom chatRoom, string name)
    {
        _chatRoom = chatRoom;
        _name  = name;
    }

    public string GetName() {
        return _name;
    }

    public void SendMessage(string message)
    {
        _chatRoom.SendMessage(this, message);
    }

    public void ReceiveMessage(string message)
    {
        Console.WriteLine("Message received: " + message);
    }
}