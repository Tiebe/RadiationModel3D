using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Osmium191m : RadioactiveSubstance
    {
        public override string name { get; } = "Osmium191m";
        public override double halfLife { get; } = 47160.0d;
        public override double atomicWeight { get; } = 190.96101d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Osmium191() }, { 0.000607d, new GammaParticle(74380.0, 0.01667) }, { 0.203408128d, new GammaParticle(10393.0, 0.1193) } } },

        };
    }
}
    