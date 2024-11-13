
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Yttrium92 : RadioactiveSubstance
    {
        public override string name { get; } = "Yttrium92";
        public override double halfLife { get; } = 12744.0d;
        public override double atomicWeight { get; } = 91.90895d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Zirconium92() } },

        };
    }
}
    
    