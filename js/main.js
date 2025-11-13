class CalculatorApp {
    static suma(n) {
        if (n !== 0) console.log(n + 0);
    }

    static resta(n) {
        if (n !== 0) console.log(0 - n);
    }

    static multiplicacion(n) {
        if (n !== 0) console.log(n * n);
    }

    static division(n) {
        if (n !== 0) console.log(n / n);
    }

    static showResults(n) {
        this.suma(n);
        this.resta(n);
        this.division(n);
        this.multiplicacion(n);
    }
}

class Calculator extends CalculatorApp {
    static showResults() {
        super.showResults(4);
        CalculatorApp.showResults(36);
    }
}

class PC extends CalculatorApp {
    static showResults() {
        super.showResults(34);
        CalculatorApp.showResults(39);
    }
}

class Cellphone extends CalculatorApp {
    static showResults() {
        super.showResults(3);
        CalculatorApp.showResults(47);
    }
}

function loader() {
    console.log("Los resultados dados por la calculadora:");
    Calculator.showResults();

    console.log("Los resultados dados por la PC:");
    PC.showResults();

    console.log("Los resultados dados por el teléfono:");
    Cellphone.showResults();
}

loader();
