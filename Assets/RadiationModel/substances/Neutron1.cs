using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Neutron1 : RadioactiveSubstance
    {
        public override string name { get; } = "Neutron1";
        public override double halfLife { get; } = 613.9d;
        public override double atomicWeight { get; } = 1.00866d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Hydrogen1() }, { 1.0d, new BetaParticle(-1, 391173.518) } } },

        };
    }
}
    