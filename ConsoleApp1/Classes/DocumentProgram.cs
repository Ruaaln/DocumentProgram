namespace ConsoleApp1.Classes;

public class DocumentProgram
{
    //1. Sənəd Açıldı
    //2. Pro və Ekspert versiyalarında redaktə edə bilər
    //3. Pro və Ekspert versiyalarında yadda saxlaya bilər

    public void OpenDocument()
    {
        Console.WriteLine("Sənəd Açıldı");
    }
    public virtual void EditDocument()
    {
        Console.WriteLine("Pro və Ekspert versiyalarında redaktə edə bilər");
    }
    public virtual void SaveDocument()
    {
        Console.WriteLine("Pro və Ekspert versiyalarında yadda saxlaya bilər");
    }
}
