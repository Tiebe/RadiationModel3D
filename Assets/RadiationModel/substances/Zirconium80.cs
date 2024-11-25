using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Zirconium80 : RadioactiveSubstance
    {
        public override string name { get; } = "Zirconium80";
        public override double halfLife { get; } = 4.6d;
        public override double atomicWeight { get; } = 79.94121d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Strontium80() }, { 1.0d, new BetaParticle(1, 7775500.0) } } },
            { 1.0d, new Dictionary<double, RadioactiveSubstance> {  } },

        };
    }
}
    