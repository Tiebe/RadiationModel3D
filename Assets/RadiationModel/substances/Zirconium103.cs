using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Zirconium103 : RadioactiveSubstance
    {
        public override string name { get; } = "Zirconium103";
        public override double halfLife { get; } = 1.3d;
        public override double atomicWeight { get; } = 102.9272d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Niobium103() }, { 1.0d, new BetaParticle(-1, 3610000.0) } } },

        };
    }
}
    