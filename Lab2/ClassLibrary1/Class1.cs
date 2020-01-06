using Lab2;

namespace ClassLibrary1 {
    public class Hydra : Unit {
        public Hydra() : base("Hydra", 20, 12, 5, 1, 10, 4) {
            PAbilities.Add("Attack", new Attack());
        }
    }

}