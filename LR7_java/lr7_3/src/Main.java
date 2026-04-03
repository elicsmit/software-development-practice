import java.util.ArrayList;
import java.util.List;

public class Main {
    public static void main(String[] args) {

        Product phone = new Electronics("Смартфон", 50000);
        Product shirt = new Clothing("Рубашка", 3000);
        Product bread = new Food("Хлеб", 50);

        Order basic = new BasicOrder();
        basic.addProduct(phone);
        basic.addProduct(bread);

        Order premium = new PremiumOrder();
        premium.addProduct(phone);
        premium.addProduct(shirt);

        System.out.println("Обычный заказ: " + basic.calculateTotal() + " руб.");
        System.out.println("Премиум заказ (со скидкой): " + premium.calculateTotal() + " руб.");
    }
}

interface Product {
    String getName();
    double getPrice();
}

interface Order {
    void addProduct(Product p);
    void removeProduct(Product p);
    double calculateTotal();
}

class Electronics implements Product {
    String name; double price;
    Electronics(String n, double p) { name = n; price = p; }
    public String getName() { return name; }
    public double getPrice() { return price; }
}

class Clothing implements Product {
    String name; double price;
    Clothing(String n, double p) { name = n; price = p; }
    public String getName() { return name; }
    public double getPrice() { return price; }
}

class Food implements Product {
    String name; double price;
    Food(String n, double p) { name = n; price = p; }
    public String getName() { return name; }
    public double getPrice() { return price; }
}

class BasicOrder implements Order {
    List<Product> items = new ArrayList<>();

    public void addProduct(Product p) { items.add(p); }
    public void removeProduct(Product p) { items.remove(p); }

    public double calculateTotal() {
        double total = 0;
        for (Product p : items) total += p.getPrice();
        return total;
    }
}

class PremiumOrder extends BasicOrder {
    @Override
    public double calculateTotal() {
        double total = super.calculateTotal();

        if (total > 10000) return total * 0.9;
        return total;
    }
}

class ShoppingCart {
    private Order currentOrder;

    ShoppingCart(Order order) { this.currentOrder = order; }

    void addItem(Product p) { currentOrder.addProduct(p); }
    void removeItem(Product p) { currentOrder.removeProduct(p); }

    void showInfo() {
        System.out.println("Итого к оплате: " + currentOrder.calculateTotal());
    }
}
