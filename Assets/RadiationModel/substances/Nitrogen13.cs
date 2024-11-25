using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Nitrogen13 : RadioactiveSubstance
    {
        public override string name { get; } = "Nitrogen13";
        public override double halfLife { get; } = 597.9d;
        public override double atomicWeight { get; } = 13.00574d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Boron13() }, { 1.0d, new BetaParticle(1, -5608210.0) }, { 1.996072d, new GammaParticle(511000.0, 0.00243) } } },

        };
    }
}
    