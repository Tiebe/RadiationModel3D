using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Titanium58 : RadioactiveSubstance
    {
        public override string name { get; } = "Titanium58";
        public override double halfLife { get; } = 0.058d;
        public override double atomicWeight { get; } = 57.96681d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Vanadium58() }, { 1.0d, new BetaParticle(-1, 4755000.0) }, { 0.8d, new GammaParticle(114000.0, 0.01088) } } },
            { 1.0d, new Dictionary<double, RadioactiveSubstance> {  } },

        };
    }
}
    