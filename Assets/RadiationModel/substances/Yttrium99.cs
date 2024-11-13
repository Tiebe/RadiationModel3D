
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Yttrium99 : RadioactiveSubstance
    {
        public override string name { get; } = "Yttrium99";
        public override double halfLife { get; } = 1.484d;
        public override double atomicWeight { get; } = 98.92416d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Zirconium99() } },

        };
    }
}
    
    