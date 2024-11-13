
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Zirconium105 : RadioactiveSubstance
    {
        public override string name { get; } = "Zirconium105";
        public override double halfLife { get; } = 0.67d;
        public override double atomicWeight { get; } = 104.93402d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Niobium105() } },

        };
    }
}
    
    