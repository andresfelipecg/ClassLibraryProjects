namespace UtilityLibraries;

//Andres Cuero
//301203787
//Use to GitHub SCM
public static class StringLibrary
{
    public static bool StartsWithUpper(this string? str)
    {
        if (string.IsNullOrWhiteSpace(str))
            return false;

        char ch = str[0];
        return char.IsUpper(ch);
    }
}