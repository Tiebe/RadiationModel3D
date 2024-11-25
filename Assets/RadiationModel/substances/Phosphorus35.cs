using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Phosphorus35 : RadioactiveSubstance
    {
        public override string name { get; } = "Phosphorus35";
        public override double halfLife { get; } = 47.3d;
        public override double atomicWeight { get; } = 34.97331d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Sulfur35() }, { 1.0d, new BetaParticle(-1, 1994205.0) }, { 0.9953112000000001d, new GammaParticle(1572250.0, 0.00079) }, { 0.00473478d, new GammaParticle(2938290.0, 0.00042) } } },

        };
    }
}
    