
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Tin126 : RadioactiveSubstance
    {
        public override string name { get; } = "Tin126";
        public override double halfLife { get; } = 7258098960000.0d;
        public override double atomicWeight { get; } = 125.90766d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Antimony126() } },

        };
    }
}
    
    