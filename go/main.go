package main

import "fmt"

type CalculatorApp struct{}

func (CalculatorApp) Suma(n float64) {
	if n != 0 {
		fmt.Println(n + 0)
	}
}

func (CalculatorApp) Resta(n float64) {
	if n != 0 {
		fmt.Println(0 - n)
	}
}

func (CalculatorApp) Multiplicacion(n float64) {
	if n != 0 {
		fmt.Println(n * n)
	}
}

func (CalculatorApp) Division(n float64) {
	if n != 0 {
		fmt.Println(n / n)
	}
}

func (CalculatorApp) ShowResults(n float64) {
	c := CalculatorApp{}
	c.Suma(n)
	c.Resta(n)
	c.Division(n)
	c.Multiplicacion(n)
}

type Calculator struct {
	CalculatorApp
}

func (Calculator) ShowResults() {
	c := CalculatorApp{}
	c.ShowResults(4)
	c.ShowResults(36)
}

type PC struct {
	CalculatorApp
}

func (PC) ShowResults() {
	c := CalculatorApp{}
	c.ShowResults(34)
	c.ShowResults(39)
}

type Cellphone struct {
	CalculatorApp
}

func (Cellphone) ShowResults() {
	c := CalculatorApp{}
	c.ShowResults(3)
	c.ShowResults(47)
}

func Loader() {
	fmt.Println("Los resultados dados por la calculadora:")
	Calculator{}.ShowResults()

	fmt.Println("Los resultados dados por la PC:")
	PC{}.ShowResults()

	fmt.Println("Los resultados dados por el teléfono:")
	Cellphone{}.ShowResults()
}

func main() {
	Loader()
}
