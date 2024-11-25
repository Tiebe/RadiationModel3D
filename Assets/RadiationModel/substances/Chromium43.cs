using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Chromium43 : RadioactiveSubstance
    {
        public override string name { get; } = "Chromium43";
        public override double halfLife { get; } = 0.0212d;
        public override double atomicWeight { get; } = 42.99789d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Titanium43() }, { 1.0d, new BetaParticle(1, 13673000.0) } } },
            { 0.7929999999999999d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Titanium42() }, { 1.0d, new ProtonParticle() }, { 0.049d, new GammaParticle(838400.0, 0.00148) }, { 0.278d, new GammaParticle(1554600.0, 0.0008) }, { 0.013999999999999999d, new GammaParticle(1936800.0, 0.00064) } } },
            { 0.11599999999999999d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Scandium41() }, { 1.0d, new ProtonParticle() } } },

        };
    }
}
    