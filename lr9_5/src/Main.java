class InvalidOperationException extends Exception {
    public InvalidOperationException(String message) { super(message); }
}

class DivisionByZeroException extends ArithmeticException {
    public DivisionByZeroException(String message) { super(message); }
}

class Calculator {

    public double calculate(double a, double b, char operation)
            throws InvalidOperationException, DivisionByZeroException {

        return switch (operation) {
            case '+' -> a + b;
            case '-' -> a - b;
            case '*' -> a * b;
            case '/' -> {
                if (b == 0) {
                    throw new DivisionByZeroException("Ошибка: Деление на ноль невозможно");
                }
                yield a / b;
            }
            default -> throw new InvalidOperationException("Ошибка: Операция '" + operation + "' не поддерживается");
        };
    }
}

public class Main {
    public static void main(String[] args) {
        Calculator calculator = new Calculator();

        try {
            calculator.calculate(10, 0, '/');
        } catch (InvalidOperationException | ArithmeticException e) {
            System.out.println(e.getMessage());
        }

        try {
            calculator.calculate(10, 5, '^');
        } catch (InvalidOperationException | ArithmeticException e) {
            System.out.println(e.getMessage());
        }

        try {
            double res = calculator.calculate(10, 5, '*');
            System.out.println("Результат: " + res);
        } catch (Exception e) {
            System.out.println(e.getMessage());
        }
    }
}
