using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Niobium91 : RadioactiveSubstance
    {
        public override string name { get; } = "Niobium91";
        public override double halfLife { get; } = 21458727360.0d;
        public override double atomicWeight { get; } = 90.90699d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new Zirconium91() } },
            { 0.000138d, new List<RadioactiveSubstance> { new BetaParticle(1, 1257590.0), new Zirconium91() } },

        };
    }
}
    
    