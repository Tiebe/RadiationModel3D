using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Zirconium107 : RadioactiveSubstance
    {
        public override string name { get; } = "Zirconium107";
        public override double halfLife { get; } = 0.146d;
        public override double atomicWeight { get; } = 106.94201d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Niobium107() }, { 1.0d, new BetaParticle(-1, 4852000.0) } } },
            { 0.23d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Niobium107() }, { 1.0d, new BetaParticle(-1, 4852000.0) } } },

        };
    }
}
    