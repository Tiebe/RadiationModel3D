using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class ProtonParticle : RadioactiveSubstance
    {
        public override string name => "Proton";
        public override double halfLife => double.PositiveInfinity;
        public override double atomicWeight => 1.007276;
        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new();
    }
}