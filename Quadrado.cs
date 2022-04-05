public class Quadrado
{

    //propriedade 
    public double Lado { get; set;}
      
    //Métodos
    public double Area{ get => Lado * Lado; }

    public double Perimetro{ get => 4 * Lado; }

    //constructor
    public Quadrado(double lado) => this.Lado = lado;
}