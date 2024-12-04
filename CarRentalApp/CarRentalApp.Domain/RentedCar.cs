namespace CarRentalApp.Domain;

public class RentedCar
{
    // <summary>
    // ID ������
    // </summary>
    public required int id { set; get; }

    // <summary>
    // �������� ���������� 
    // </summary>
    public required Car Car { set; get; }

    // <summary>
    // ����� �������
    // </summary>
    public required RentalPlace RentalPlace { set; get; }

    // <summary>
    // ������ ���������� ������
    // </summary>
    public required Client Client { set; get; }

    // <summary>
    // ����� ������
    // </summary>
    public required DateTime IssueTime { set; get; }

    // <summary>
    // ���� ������
    // </summary>
    public TimeSpan? RentalPeriod { set; get; }

    // <summary>
    // ����� ��������
    // </summary>
    public DateTime? ReturnTime { set; get; }

    // <summary>
    // �����, � ������� ����������
    // </summary>
    public RentalPlace? ReturnRentalPlace { set; get; }


}

