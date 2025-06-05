using ConsoleApp1.Classes;

class Program
{
    static void Main()
    {
        Console.Write("Zəhmət olmasa açarı daxil edin (əsas/pro/ekspert): ");
        string key = Console.ReadLine()?.ToLower()!;

        DocumentProgram docProgram;

        switch (key.ToLower())
        {
            case "pro":
                docProgram = new ProDocumentProgram();
                break;

            case "ekspert":
                docProgram = new ExpertDocument();
                break;

            default:
                docProgram = new DocumentProgram();
                break;
        }

        docProgram.OpenDocument();
        docProgram.EditDocument();
        docProgram.SaveDocument();
    }
}