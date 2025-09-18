public class Rectangulo : figura
{
    // Propiedades para la base y la altura.
    public double Base { get; set; }
    public double Altura { get; set; }

    // El constructor que recibe la base y la altura.
    public Rectangulo(double baseRectangulo, double alturaRectangulo)
    {
        Base = baseRectangulo;
        Altura = alturaRectangulo;
    }

    // El método que sobrescribe el de la clase padre.
    // 'override' indica el polimorfismo.
    public override double CalcularArea()
    {
        return Base * Altura;
    }
}