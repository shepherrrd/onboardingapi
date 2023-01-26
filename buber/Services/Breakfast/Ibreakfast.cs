using buber.Controllers;
using buber.Model;

namespace buber.Services.Breakfasts;

public interface Ibreakfast {
   void CreateBreakfast(Breakfast breakfast);
    void CreateBreakfast(Useracct breakfast);
    void CreateUser(Breakfast breakfast);
    

  
    void DeleteBreakfast(Guid id);
    Breakfast GetBreakfast(Guid id);
    void UpsertBreakfast(Breakfast breakfast);

    void CreateUser(Useracct user);
      void CreatePassword (Useracct user);
    Useracct GetUser(Guid id);
}

