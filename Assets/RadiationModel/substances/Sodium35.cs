using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Sodium35 : RadioactiveSubstance
    {
        public override string name { get; } = "Sodium35";
        public override double halfLife { get; } = 0.0018d;
        public override double atomicWeight { get; } = 35.04061d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Magnesium35() }, { 1.0d, new BetaParticle(-1, 11095000.0) } } },
            { 0.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Magnesium35() }, { 1.0d, new BetaParticle(-1, 11095000.0) } } },
            { 1.0d, new Dictionary<double, RadioactiveSubstance> {  } },

        };
    }
}
    