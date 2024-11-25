using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Yttrium78m : RadioactiveSubstance
    {
        public override string name { get; } = "Yttrium78m";
        public override double halfLife { get; } = 0.053d;
        public override double atomicWeight { get; } = 77.94399d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Rubidium78() }, { 1.0d, new BetaParticle(1, 7382500.0) }, { 1.0d, new GammaParticle(279000.0, 0.00444) }, { 0.9d, new GammaParticle(504000.0, 0.00246) }, { 0.4d, new GammaParticle(713000.0, 0.00174) } } },
            { 1.0d, new Dictionary<double, RadioactiveSubstance> {  } },

        };
    }
}
    