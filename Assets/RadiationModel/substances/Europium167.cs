using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Europium167 : RadioactiveSubstance
    {
        public override string name { get; } = "Europium167";
        public override double halfLife { get; } = 0.86d;
        public override double atomicWeight { get; } = 166.95301d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Gadolinium167() }, { 1.0d, new BetaParticle(-1, 3503000.0) } } },
            { 0.0195d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Gadolinium167() }, { 1.0d, new BetaParticle(-1, 3503000.0) } } },

        };
    }
}
    