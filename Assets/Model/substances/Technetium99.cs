using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Technetium99 : RadioactiveSubstance
    {
        public Technetium99() => charge = 0;
        public Technetium99(int charge) => this.charge = charge;
        public override string name { get; } = "Technetium-99";
        public override double halfLife { get; } = 211100 * TimeConstants.SECONDS_IN_YEAR;
        public override double atomicWeight { get; } = 98.9063;
        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new();
    }
}