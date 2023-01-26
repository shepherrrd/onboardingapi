using buber.Model;

namespace buber.Services.Breakfasts;

public class BreakfastService : Ibreakfast
{
    private static readonly Dictionary <Guid, Breakfast> _breakfast = new();
    private static readonly Dictionary <Guid, Useracct> _user = new();

    public void CreateBreakfast(Breakfast breakfast)
    {
        _breakfast.Add(breakfast.Id, breakfast);
    }

    public void CreateBreakfast(Useracct breakfast)
    {
        throw new NotImplementedException();
    }

    public void CreatePassword(Useracct user)
    {
       _user[user.id] = user;
    }

    public void CreateUser(Breakfast breakfast)
    {
        throw new NotImplementedException();
    }

    public void CreateUser(Useracct user)
    {
        _user.Add(user.id, user);
    }

    public void DeleteBreakfast(Guid id)
    {
        _breakfast.Remove(id);
    }

    public Breakfast GetBreakfast(Guid id)
    {
        return _breakfast[id];
    }

    public void Getuser(Useracct user)
    {
        throw new NotImplementedException();
    }

    public  Useracct GetUser(Guid id)
    {
       return _user[id];
    }

    public void UpsertBreakfast(Breakfast breakfast)
    {
        _breakfast[breakfast.Id] = breakfast;
    }

   
}

