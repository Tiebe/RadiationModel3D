using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Gadolinium166 : RadioactiveSubstance
    {
        public override string name { get; } = "Gadolinium166";
        public override double halfLife { get; } = 4.8d;
        public override double atomicWeight { get; } = 165.94163d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Terbium166() }, { 1.0d, new BetaParticle(-1, 1718950.0) } } },

        };
    }
}
    