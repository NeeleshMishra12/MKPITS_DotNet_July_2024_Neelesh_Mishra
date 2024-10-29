import java.util.Scanner;

public class RangeCheck {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        System.out.print("Enter a number: ");
        int num = scanner.nextInt();

        if (num >= 10 && num <= 50) {
            System.out.println("The number is within the range 10-50.");
        } else {
            System.out.println("The number is out of the range 10-50.");
        }

        scanner.close();
    }
}
