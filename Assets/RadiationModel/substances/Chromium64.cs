using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Chromium64 : RadioactiveSubstance
    {
        public override string name { get; } = "Chromium64";
        public override double halfLife { get; } = 0.0429d;
        public override double atomicWeight { get; } = 63.96389d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Manganese64() }, { 1.0d, new BetaParticle(-1, 4674500.0) }, { 0.11d, new GammaParticle(186400.0, 0.00665) }, { 0.08d, new GammaParticle(962300.0, 0.00129) } } },
            { 1.0d, new Dictionary<double, RadioactiveSubstance> {  } },

        };
    }
}
    