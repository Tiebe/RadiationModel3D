using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class GammaParticle : RadioactiveSubstance
    {
        public override string name { get; } = "Gamma particle";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 0;
        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new();
    }
}