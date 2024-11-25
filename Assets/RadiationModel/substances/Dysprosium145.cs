using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Dysprosium145 : RadioactiveSubstance
    {
        public override string name { get; } = "Dysprosium145";
        public override double halfLife { get; } = 6.0d;
        public override double atomicWeight { get; } = 144.93747d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Gadolinium145() }, { 1.0d, new BetaParticle(1, 7342000.0) } } },
            { 0.5d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Gadolinium144() }, { 1.0d, new ProtonParticle() } } },

        };
    }
}
    