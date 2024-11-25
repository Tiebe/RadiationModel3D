using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Nickel69m : RadioactiveSubstance
    {
        public override string name { get; } = "Nickel69m";
        public override double halfLife { get; } = 3.5d;
        public override double atomicWeight { get; } = 68.93595d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Copper69() }, { 1.0d, new BetaParticle(-1, 3039100.0) }, { 0.74d, new GammaParticle(1297900.0, 0.00096) } } },
            { 0.0001d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Nickel69() } } },

        };
    }
}
    