using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Titanium61 : RadioactiveSubstance
    {
        public override string name { get; } = "Titanium61";
        public override double halfLife { get; } = 0.015d;
        public override double atomicWeight { get; } = 60.98243d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Vanadium61() }, { 1.0d, new BetaParticle(-1, 6905000.0) } } },
            { 1.0d, new Dictionary<double, RadioactiveSubstance> {  } },
            { 1.0d, new Dictionary<double, RadioactiveSubstance> {  } },

        };
    }
}
    