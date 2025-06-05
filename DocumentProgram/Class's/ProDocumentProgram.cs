using System.Reflection.Metadata;

namespace DocumentProgram.Class_s;

internal class ProDocumentProgram : DocumentProgram
{
    //1. Sənəd Açıldı
    //2. Document Reded(burda override elediyiniz metodu seald edirsiniz)
    //3. Sənəd doc formatında saxlanılır, pdf formatı üçün Ekspert paketi alın
    public sealed override void EditDocument()
    {
        Console.WriteLine("Document Redaktə edildi");
    }

    public override void SaveDocument()
    {
        Console.WriteLine("Sənəd doc formatında saxlanılır, pdf formatı üçün Ekspert paketi alın");
    }
}
