using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Samarium151 : RadioactiveSubstance
    {
        public override string name { get; } = "Samarium151";
        public override double halfLife { get; } = 2840123337.71328d;
        public override double atomicWeight { get; } = 150.91994d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Europium151() }, { 1.0d, new BetaParticle(-1, 38300.0) }, { 0.00031800000000000003d, new GammaParticle(21543.0, 0.05755) }, { 0.0011539584d, new GammaParticle(6603.0, 0.18777) } } },

        };
    }
}
    