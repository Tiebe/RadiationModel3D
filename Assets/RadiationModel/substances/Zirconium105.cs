using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Zirconium105 : RadioactiveSubstance
    {
        public override string name { get; } = "Zirconium105";
        public override double halfLife { get; } = 0.66d;
        public override double atomicWeight { get; } = 104.93402d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Niobium105() }, { 1.0d, new BetaParticle(-1, 4229000.0) } } },
            { 0.02d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Niobium105() }, { 1.0d, new BetaParticle(-1, 4229000.0) } } },

        };
    }
}
    