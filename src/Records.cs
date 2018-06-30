public IEquatable<T> {

    // Who wants to write an impl?
    // Ugh -- so much boilerplate!
    bool Equals(T obj);

    int GetHashCode();
}

public class Pizza(
    Crust Crust,
    Sauce Sauce,
    IEnumerable<Topping> Toppings);

public class Pizza : IEquatable<Pizza> {
    public Crust Crust { get; }
    public Sauce Sauce { get; }
    public IEnumerable<Topping> Toppings { get; }

    public Pizza(
        Crust Crust,
        Sauce Sauce,
        IEnumerable<Topping> Toppings) {
        this.Crust = Crust;
        this.Sauce = Sauce;
        this.Toppings = Toppings;
    }
 
    public bool Equals(Pizza other)
        => Equals(Crust, other?.Crust)
        && Equals(Sauce, other?.Sauce)
        && Equals(Toppings, other?.Toppings);
 
    public override bool Equals(object other)
        => other is Pizza pizza ? pizza.Equals(this) : false;
 
    public override int GetHashCode()
        => Crust?.GetHashCode() * 7 +
           Sauce?.GetHashCode() * 13 +
           Toppings?.GetHashCode() * 51;

    public void Deconstruct(
        out Crust crust, 
        out Sauce sauce,
        out IEnumerable<Topping> toppings) {
        crust = Crust;
        sauce = Sauce;
        toppings = Toppings;
    }
 
    public Pizza With(
        var crust = this.Crust,
        var sauce = this.Sauce,
        var toppings = this.Toppings)
        => new Pizza(crust, sauce, toppings);
}

// Auto deconstruct!
var (crust, sauce, toppings) = pizza;

// "With" syntax, copy immutable objects "with" modifications
var supreme =
    veggiePizza.With(toppings: new[] { 
        Topping.Pepperoni,
        Topping.Sausage
    });

// Syntactic sugar, "with expressions"
var bestPizza =
    supreme with { crust = Crust.Thin };









// (っ◔◡◔)っ
var bestPizza =
    supreme with { crust = Crust.ChicagoDeepDish };














// Hacker!
