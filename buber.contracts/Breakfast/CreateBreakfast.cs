namespace buber.contracts.Breakfast;

    public record CreateBreakfast(
        String name,
        String Description,
        DateTime StartDate,
        DateTime EndDate,
        List<String> savory,
        List<String> sweet


    
    );
    
