
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Yttrium96m : RadioactiveSubstance
    {
        public override string name { get; } = "Yttrium96m";
        public override double halfLife { get; } = 9.6d;
        public override double atomicWeight { get; } = 95.91756d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Zirconium96() } },

        };
    }
}
    
    