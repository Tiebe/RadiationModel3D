using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class NeutronParticle : RadioactiveSubstance
    {
        public override string name => "Neutron";
        public override double halfLife => double.PositiveInfinity;
        public override double atomicWeight => 1.008665;
        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new();
    }
}