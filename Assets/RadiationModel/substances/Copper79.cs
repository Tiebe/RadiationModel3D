using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Copper79 : RadioactiveSubstance
    {
        public override string name { get; } = "Copper79";
        public override double halfLife { get; } = 0.241d;
        public override double atomicWeight { get; } = 78.95447d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Zinc79() }, { 1.0d, new BetaParticle(-1, 5511150.0) } } },
            { 0.66d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Zinc79() }, { 1.0d, new BetaParticle(-1, 5511150.0) } } },
            { 1.0d, new Dictionary<double, RadioactiveSubstance> {  } },

        };
    }
}
    