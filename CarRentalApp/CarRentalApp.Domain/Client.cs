namespace CarRentalApp.Domain;

public class Client
{
    // <summary>
    // ID �������
    // </summary>
    public required int id { set; get; }

    // <summary>
    // ����� �������� 
    // </summary>
    public required int PassportNumber { set; get; }

    // <summary>
    // ���
    // </summary>
    public required string FullName { set; get; }

    // <summary>
    // ���� �������� 
    // </summary>
    public required DateOnly BirthDate { set; get; }

}

