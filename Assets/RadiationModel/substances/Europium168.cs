using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Europium168 : RadioactiveSubstance
    {
        public override string name { get; } = "Europium168";
        public override double halfLife { get; } = 0.2d;
        public override double atomicWeight { get; } = 167.95786d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Gadolinium168() }, { 1.0d, new BetaParticle(-1, 4450000.0) } } },
            { 1.0d, new Dictionary<double, RadioactiveSubstance> {  } },

        };
    }
}
    