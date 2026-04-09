import java.util.HashSet;
import java.util.List;
import java.util.Set;

class SeatAlreadyReservedException extends Exception {
    public SeatAlreadyReservedException(String m) { super(m); }
}
class SeatNotReservedException extends Exception {
    public SeatNotReservedException(String m) { super(m); }
}
class InvalidSeatNumberException extends Exception {
    public InvalidSeatNumberException(String m) { super(m); }
}

class SeatReservation {
    private final int totalSeats;
    private final Set<Integer> reservedSeats = new HashSet<>();

    public SeatReservation(int totalSeats) {
        this.totalSeats = totalSeats;
    }

    public void reserveSeat(int seatNumber) throws InvalidSeatNumberException, SeatAlreadyReservedException {
        if (seatNumber < 1 || seatNumber > totalSeats) {
            throw new InvalidSeatNumberException("Место " + seatNumber + " не существует");
        }
        if (reservedSeats.contains(seatNumber)) {
            throw new SeatAlreadyReservedException("Место " + seatNumber + " уже забронировано");
        }
        reservedSeats.add(seatNumber);
    }

    public void cancelReservation(int seatNumber) throws InvalidSeatNumberException, SeatNotReservedException {
        if (seatNumber < 1 || seatNumber > totalSeats) {
            throw new InvalidSeatNumberException("Неверный номер места");
        }
        if (!reservedSeats.contains(seatNumber)) {
            throw new SeatNotReservedException("Место " + seatNumber + " не было забронировано");
        }
        reservedSeats.remove(seatNumber);
    }

    public void reserveMultiple(List<Integer> seatNumbers) {
        Set<Integer> backup = new HashSet<>(reservedSeats);
        try {
            for (int seat : seatNumbers) {
                reserveSeat(seat);
            }
            System.out.println("Массовое бронирование успешно");
        } catch (Exception e) {
            reservedSeats.clear();
            reservedSeats.addAll(backup); // Откат
            System.out.println("Ошибка бронирования: " + e.getMessage() + ". Выполнен откат.");
        }
    }
}

public class Main {
    public static void main(String[] args) {
        SeatReservation system = new SeatReservation(100);

        try {
            system.reserveSeat(5);
            system.reserveSeat(5);
        } catch (Exception e) {
            System.out.println(e.getMessage());
        }

        system.reserveMultiple(List.of(10, 20, 105));
    }
}
