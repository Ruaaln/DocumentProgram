using System;
using DocumentProgram.Class_s;


class Program
{
    static void Main()
    {
        Console.Write("Zəhmət olmasa açarı daxil edin (əsas/pro/ekspert): ");
        string key = Console.ReadLine()?.ToLower();

        DocumentProgram docProgram;

        switch (key)
        {
            case "pro":
                docProgram = new ProDocumentProgram();
                break;

            case "ekspert":
                docProgram = new ExpertDocumentProgram();
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
