using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Samarium166 : RadioactiveSubstance
    {
        public override string name { get; } = "Samarium166";
        public override double halfLife { get; } = 0.8d;
        public override double atomicWeight { get; } = 165.95658d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Europium166() }, { 1.0d, new BetaParticle(-1, 3150000.0) } } },
            { 1.0d, new Dictionary<double, RadioactiveSubstance> {  } },

        };
    }
}
    