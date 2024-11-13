using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class AlphaParticle : RadioactiveSubstance
    {
        public override string name => "Helium-4 nucleus";
        public override double halfLife => double.PositiveInfinity;
        public override double atomicWeight => 4.002602d;
        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new();
    }
}