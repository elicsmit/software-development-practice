import java.util.List;
import java.util.Arrays;

class InsufficientFundsException extends Exception {
    public InsufficientFundsException(String message) {
        super(message);
    }
}

class BankAccount {
    private double balance;

    public BankAccount(double balance) {
        this.balance = balance;
    }

    public void deposit(double amount) {
        balance += amount;
    }

    public void withdraw(double amount) throws InsufficientFundsException {
        if (amount > balance) {
            throw new InsufficientFundsException("Недостаточно средств");
        }
        balance -= amount;
    }

    public void transaction(List<Double> operations) {
        double initialState = this.balance;
        try {
            for (double amount : operations) {
                if (amount >= 0) deposit(amount);
                else withdraw(Math.abs(amount));
            }
        } catch (InsufficientFundsException e) {
            this.balance = initialState;
            System.out.println("Ошибка транзакции: " + e.getMessage());
        }
    }

    public double getBalance() {
        return balance;
    }
}

public class Main {
    public static void main(String[] args) {
        BankAccount account = new BankAccount(1000);

        try {
            account.withdraw(1500);
        } catch (InsufficientFundsException e) {
            System.out.println(e.getMessage());
        }

        account.transaction(Arrays.asList(500.0, -2000.0));

        System.out.println("Текущий баланс: " + account.getBalance());
    }
}
