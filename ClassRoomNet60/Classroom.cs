namespace ClassRoomNet60;

public class Classroom
{
    public string KlasseNavn;
    List<Studerende> Klasseliste;
    DateTime SemesterStart;

    public Classroom(string klasseNavn, List<Studerende> klasseliste, DateTime semesterStart)
    {
        KlasseNavn = klasseNavn;
        Klasseliste = klasseliste;
        SemesterStart = semesterStart;
    }
}

    