using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Uranium234 : RadioactiveSubstance
    {
        public override string name { get; } = "Uranium-234";
        public override double halfLife { get; } = 245500;
        public override double atomicWeight { get; } = 234.0436;
        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new();
    }
}