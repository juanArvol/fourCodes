public class calculatorApp {
    private static double number;

    public calculatorApp(){
    }

    public static void suma(double n){
        double count=0;
        number=n;
        if (n !=0) {
            System.out.println(number+count);
        }
    }
    public static void resta(double n){
        double count=0;
        number=n;
        if (n !=0) {
            System.out.println(count-number);
        }
    }
    public static void multiplicacion(double n){
        double count=0;
        number=n;
        if(count==0) count=n;
        if (n !=0) {
            System.out.println(number*count);
        }
    }
    public static void division(double n){
        double count=0;
        number=n;
        if(count==0) count=n;
        if (n !=0) {
            System.out.println(number/count);
        }
    }
    public static void showResults(double n){
        suma(n);
        resta(n);
        division(n);
        multiplicacion(n);
    }
}
