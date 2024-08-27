namespace ClassRoomNet60;

public class Studerende
{
    public string Navn;
    public int fødselsmåned;
    public int fødselsdag;

    public Studerende(string navn, int fødselsmåned, int fødselsdag)
    {
        Navn = navn;
        this.fødselsmåned = fødselsmåned;
        this.fødselsdag = fødselsdag;
    }
}