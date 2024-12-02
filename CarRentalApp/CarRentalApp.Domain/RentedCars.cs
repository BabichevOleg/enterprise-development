namespace CarRentalApp.Domain;

public class RentedCars
{
    // <summary>
    // ID ������
    // </summary>
    public required int? ID { set; get; }

    // <summary>
    // �������� ���������� 
    // </summary>
    public required Cars? Car { set; get; }

    // <summary>
    // ����� �������
    // </summary>
    public required RentalPlaces? RentalPlace { set; get; }

    // <summary>
    // ������ ���������� ������
    // </summary>
    public required Clients? Client { set; get; }

    // <summary>
    // ����� ������
    // </summary>
    public required DateTime? IssueTime { set; get; }

    // <summary>
    // ���� ������
    // </summary>
    public required TimeSpan? RentalPeriod { set; get; }

    // <summary>
    // ����� ��������
    // </summary>
    public required DateTime? ReturnTime { set; get; }

    // <summary>
    // �����, � ������� ����������
    // </summary>
    public required RentalPlaces? ReturnRentalPlace { set; get; }


}

