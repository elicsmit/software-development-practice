import java.time.LocalDate;
import java.time.format.DateTimeFormatter;
import java.time.format.DateTimeParseException;
import java.util.Scanner;

class DateParseException extends Exception {
    public DateParseException(String message) {
        super(message);
    }
}

public class Main {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        System.out.println("Введите дату. Доступные форматы: yyyy-MM-dd, dd-MM-yyyy, MM/dd/yyyy");
        String input = scanner.nextLine();

        try {
            LocalDate date = parseDate(input);
            System.out.println("Дата успешно преобразована: " + date);
        } catch (DateParseException e) {
            System.out.println(e.getMessage());
        } finally {
            scanner.close();
        }
    }

    public static LocalDate parseDate(String dateStr) throws DateParseException {
        String[] patterns = {"yyyy-MM-dd", "dd-MM-yyyy", "MM/dd/yyyy"};

        for (String pattern : patterns) {
            try {
                DateTimeFormatter formatter = DateTimeFormatter.ofPattern(pattern);
                return LocalDate.parse(dateStr, formatter);
            } catch (DateTimeParseException e) {

            }
        }
        throw new DateParseException("Неверный формат даты. Используйте: yyyy-MM-dd, dd-MM-yyyy или MM/dd/yyyy");
    }
}
