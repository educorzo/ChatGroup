namespace ChatGroup;


public interface IChatRoom //IMediator
{
    void RegisterPatient(Patient patient);
    void SendMessage(Patient patient, string message);
}

public class ChatRoom : IChatRoom //Mediator
{
    private List<Patient> _patients = new ();
    public void RegisterPatient(Patient patient)
    {
        _patients.Add(patient);
        Console.WriteLine(patient.GetName() + " registered");
    }

    public void SendMessage(Patient patient, string message)
    {
        foreach (var existingPatient in _patients)
            if (existingPatient.GetName() != patient.GetName())
                existingPatient.ReceiveMessage(message);
    }
}