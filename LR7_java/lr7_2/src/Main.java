public class Main {
    public static void main(String[] args) {

        Shape circle = new Circle(5);
        Shape rectangle = new Rectangle(4, 6);

        System.out.println("Круг: площадь = " + circle.area() + ", периметр = " + circle.perimeter());
        System.out.println("Прямоугольник: площадь = " + rectangle.area() + ", периметр = " + rectangle.perimeter());
    }
}

interface Shape {
    double area();
    double perimeter();
}

class Circle implements Shape {
    double r;

    Circle(double r) { this.r = r; }

    @Override
    public double area() { return Math.PI * r * r; }

    @Override
    public double perimeter() { return 2 * Math.PI * r; }
}

class Rectangle implements Shape {
    double w, h;

    Rectangle(double w, double h) {
        this.w = w;
        this.h = h;
    }

    @Override
    public double area() { return w * h; }

    @Override
    public double perimeter() { return 2 * (w + h); }
}
