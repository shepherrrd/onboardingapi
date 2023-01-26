namespace buber.Model;


public class Breakfast{
    public Guid Id {get; }
    public string name {get; }
    public string Description {get; }

    public  DateTime StartDate {get; }
     public   DateTime EndDate {get; }
     public   DateTime LastModified {get; }
    public    List<string> savory {get; }
    public  List<string> sweet {get; }
    public Breakfast(
        Guid id, string name, string description, DateTime startDateTime, DateTime endDateTime, DateTime lastModifiedDateTime, List<string> savory, List<string> sweet)
    {
        Id = id;
        this.name = name;
        Description = description;
        StartDate = startDateTime;
        EndDate = endDateTime;
        LastModified = lastModifiedDateTime;
        this.savory = savory;
        this.sweet = sweet;
    }
}

public class Useracct{
    //#nullable disable

    public Guid id {get;}
    public string? name {get;}
    public string? username {get;}
    public string? password {get;}

    public Useracct(Guid id, string? name, string? username, string password)
    {
        this.id = id;
        this.name = name;
        this.username = username;
        this.password = password;
    }

    // public Useracct(string password)
    // {
    //     this.password = password1;
    // }
}
