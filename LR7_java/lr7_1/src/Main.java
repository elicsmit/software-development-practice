public class Main {
    public static void main(String[] args) {

        Shapes.Circle circle = new Shapes.Circle(5);
        Shapes.Square square = new Shapes.Square(4);

        System.out.println("Площадь круга: " + Utils.round(circle.getArea()));
        System.out.println("Периметр квадрата: " + square.getPerimeter());
    }
}

class Shapes {
    static class Circle {
        double r;
        Circle(double r) { this.r = r; }
        double getArea() { return Math.PI * r * r; }
    }

    static class Square {
        double side;
        Square(double side) { this.side = side; }
        double getPerimeter() { return 4 * side; }
    }
}

class Utils {
    static double round(double value) {
        return Math.round(value * 100.0) / 100.0;
    }
}
