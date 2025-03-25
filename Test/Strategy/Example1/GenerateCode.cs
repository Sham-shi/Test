
namespace Lessons.Strategy.Example1;

public enum Language
{
    Java,
    Cpp,
    Rust
}


public class GenerateCode
{
    private Dictionary<Language, IGenerateLanguage> codeByLanguage;
    public GenerateCode()
    {
        codeByLanguage = new Dictionary<Language, IGenerateLanguage>();

        codeByLanguage.Add(Language.Java, new JavaGenerate());
        codeByLanguage.Add(Language.Cpp, new CppGenerate());
        codeByLanguage.Add(Language.Rust, new RustGenerate());
    }

    public string Generate(Language language)
    {
        return codeByLanguage[language].Generate();
    }
}
