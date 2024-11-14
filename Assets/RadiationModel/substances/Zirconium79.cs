using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Zirconium79 : RadioactiveSubstance
    {
        public override string name { get; } = "Zirconium79";
        public override double halfLife { get; } = 0.056d;
        public override double atomicWeight { get; } = 78.94979d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 11030000.0), new Yttrium79() } },

        };
    }
}
    
    