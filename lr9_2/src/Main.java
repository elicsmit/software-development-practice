import java.io.File;
import java.io.FileNotFoundException;
import java.util.ArrayList;
import java.util.List;
import java.util.Scanner;

class InvalidDataFormatException extends Exception {
    public InvalidDataFormatException(String message) {
        super(message);
    }
}

public class Main {
    public static void main(String[] args) {
        try {
            int[] numbers = parseFile("data.txt");
            for (int n : numbers) System.out.print(n + " ");
        } catch (FileNotFoundException e) {
            System.err.println("Файл не найден");
        } catch (InvalidDataFormatException | NumberFormatException e) {
            System.err.println("Ошибка данных: " + e.getMessage());
        }
    }

    public static int[] parseFile(String filePath) throws InvalidDataFormatException, FileNotFoundException {
        File file = new File(filePath);
        Scanner scanner = null;
        List<Integer> result = new ArrayList<>();

        try {
            scanner = new Scanner(file);
            while (scanner.hasNextLine()) {
                String line = scanner.nextLine();

                if (line.trim().isEmpty()) {
                    throw new InvalidDataFormatException("Файл содержит пустые строки");
                }

                try {
                    result.add(Integer.parseInt(line.trim()));
                } catch (NumberFormatException e) {
                    throw new InvalidDataFormatException("Некорректный формат числа: " + line);
                }
            }
        } finally {

            if (scanner != null) {
                scanner.close();
            }
        }

        return result.stream().mapToInt(i -> i).toArray();
    }
}
