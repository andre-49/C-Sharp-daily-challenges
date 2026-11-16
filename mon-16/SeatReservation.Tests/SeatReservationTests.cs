using Xunit;

public class SeatReservationTests
{
[Fact]
public void ReserveSeat_AvailableSeat_ReturnsTrue()
{
var reservation = new SeatReservation(5);    
    bool result = reservation.ReserveSeat(2);

    Assert.True(result);
    Assert.Equal(4, reservation.GetAvailableSeatCount());
}

[Fact]
public void ReserveSeat_AlreadyReserved_ReturnsFalse()
{
    var reservation = new SeatReservation(5);

    reservation.ReserveSeat(2);

    bool result = reservation.ReserveSeat(2);

    Assert.False(result);
    Assert.Equal(4, reservation.GetAvailableSeatCount());
}

[Theory]
[InlineData(0)]
[InlineData(6)]
public void ReserveSeat_InvalidSeatNumber_ThrowsException(int seatNumber)
{
    var reservation = new SeatReservation(5);

    Assert.Throws<ArgumentOutOfRangeException>(
        () => reservation.ReserveSeat(seatNumber)
    );
}

[Fact]
public void Constructor_ZeroSeats_ThrowsException()
{
    Assert.Throws<ArgumentOutOfRangeException>(
        () => new SeatReservation(0)
    );
}
}