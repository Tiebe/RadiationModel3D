using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Europium166 : RadioactiveSubstance
    {
        public override string name { get; } = "Europium166";
        public override double halfLife { get; } = 1.7d;
        public override double atomicWeight { get; } = 165.94981d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Gadolinium166() }, { 1.0d, new BetaParticle(-1, 3810450.0) } } },
            { 1.0d, new Dictionary<double, RadioactiveSubstance> {  } },

        };
    }
}
    