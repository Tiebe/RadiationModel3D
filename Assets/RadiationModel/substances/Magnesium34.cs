using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Magnesium34 : RadioactiveSubstance
    {
        public override string name { get; } = "Magnesium34";
        public override double halfLife { get; } = 0.02d;
        public override double atomicWeight { get; } = 34.00894d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Aluminum34() }, { 1.0d, new BetaParticle(-1, 5660300.0) } } },
            { 1.0d, new Dictionary<double, RadioactiveSubstance> {  } },

        };
    }
}
    