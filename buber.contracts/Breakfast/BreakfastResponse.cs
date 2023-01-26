namespace buber.contracts.Breakfast;

    public record BreakfastResponse(
        Guid Id,
        String name,
        String Description,
        DateTime StartDate,
        DateTime EndDate,
        DateTime LastModified,
        List<String> savory,
        List<String> sweet


    
    );
    
