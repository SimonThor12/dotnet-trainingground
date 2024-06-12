namespace TrainingGround;

public enum AgeCategory
{
    Kid,
    Adult,
    Prime
}
public class AgeCalculator
{

    public static int GetAge(int birthYear, int currentYear)
    {
        return currentYear - birthYear;
    }

    public static AgeCategory GetAgeCategory(Person person, int currentYear)
    {
        var age = GetAge(person.BirthYear, currentYear);

        if (age == 50)
        {
            return AgeCategory.Prime;
        }
        else if (age < 18)
        {
            return AgeCategory.Kid;
        }
        return AgeCategory.Adult;
    }

    public static string GetAgeSpan(AgeCategory category) {
        return category switch
        {
            AgeCategory.Kid => "Under 18 years",
            AgeCategory.Adult => "Over 18 years, bur not 50 years old",
            AgeCategory.Prime => "50 exactly, and proud!",
            _ => "Unknown"
        };
    }

}
