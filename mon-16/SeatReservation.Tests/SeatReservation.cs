
public class SeatReservation
{
    private readonly bool[] _reservedSeats;

    public SeatReservation(int seatCount)
    {
        ArgumentOutOfRangeException.ThrowIfNegativeOrZero(seatCount);
        _reservedSeats = new bool[seatCount];
    }

    public bool ReserveSeat(int seatNumber)
    {
        if(seatNumber <= 0  || seatNumber > _reservedSeats.Count())
            throw new ArgumentOutOfRangeException("The desired seat number is out of range!");
        if(_reservedSeats[seatNumber-1])
            return false;
        _reservedSeats[seatNumber-1] = true;
        return true;
    }

    public int GetAvailableSeatCount()
    {
        return _reservedSeats.Where(seat => !seat).Count();
    }
}