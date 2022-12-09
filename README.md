 # Cours C# Question : A quoi sert les modificateurs d'accès et présenter un exemple qui illustre cela

# - Les modificateurs d'accès sont utilisés pour contrôler l'accès aux éléments d'une classe ou d'un objet. En C#, il existe différents modificateurs d'accès, tels que public, private, protected et internal. Par exemple, si vous définissez une variable age en tant que private, elle ne sera accessible que depuis l'intérieur de la classe où elle a été définie. Voici un exemple de code qui illustre l'utilisation de modificateurs d'accès en C# :

# public class Person
# {
# private int age; // La variable age est accessible uniquement depuis l'intérieur de la classe Person
#   public void SetAge(int value)
#    {
#        if (value >= 0 && value <= 150)
#        {
#            age = value;
#        }
#    }
#    public int GetAge()
#    {
#        return age;
#    }
# }
# Dans cet exemple, la variable age est déclarée en tant que private, ce qui signifie qu'elle ne peut être lue ou modifiée que depuis l'intérieur de la classe Person. Les méthodes SetAge et GetAge sont déclarées en tant que public, ce qui signifie qu'elles peuvent être appelées depuis l'extérieur de la classe.
