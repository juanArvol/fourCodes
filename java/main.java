public class main {

    public static void loader(){
        System.out.println("los resultados dados por la calculadora: ");
        calculator.showResults();
        
        System.out.println("los resultados dados por la pc: ");
        pc.showResults();
        
        System.out.println("los resultados dados por el telofono: ");
        cellphone.showResults();
    }
    public static void main(String[] args) {
        loader();
    }
}
