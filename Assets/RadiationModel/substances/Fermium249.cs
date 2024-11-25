using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Fermium249 : RadioactiveSubstance
    {
        public override string name { get; } = "Fermium249";
        public override double halfLife { get; } = 123.0d;
        public override double atomicWeight { get; } = 249.07893d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.84d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Californium249() }, { 1.0d, new BetaParticle(1, 1898150.00001) } } },
            { 0.16d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Californium245() }, { 1.0d, new AlphaParticle(8730802.09) } } },

        };
    }
}
    