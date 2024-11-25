using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Gadolinium168 : RadioactiveSubstance
    {
        public override string name { get; } = "Gadolinium168";
        public override double halfLife { get; } = 3.03d;
        public override double atomicWeight { get; } = 167.94831d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Terbium168() }, { 1.0d, new BetaParticle(-1, 2315500.0) } } },

        };
    }
}
    