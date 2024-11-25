using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Terbium139 : RadioactiveSubstance
    {
        public override string name { get; } = "Terbium139";
        public override double halfLife { get; } = 1.6d;
        public override double atomicWeight { get; } = 138.94833d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Europium139() }, { 1.0d, new BetaParticle(1, 8634000.0) } } },
            { 1.0d, new Dictionary<double, RadioactiveSubstance> {  } },
            { 1.0d, new Dictionary<double, RadioactiveSubstance> {  } },

        };
    }
}
    