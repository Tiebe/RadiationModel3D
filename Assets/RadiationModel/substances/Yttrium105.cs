
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Yttrium105 : RadioactiveSubstance
    {
        public override string name { get; } = "Yttrium105";
        public override double halfLife { get; } = 0.095d;
        public override double atomicWeight { get; } = 104.94571d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Zirconium105() } },

        };
    }
}
    
    