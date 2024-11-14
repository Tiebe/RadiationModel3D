using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Rhodium96m : RadioactiveSubstance
    {
        public override string name { get; } = "Rhodium96m";
        public override double halfLife { get; } = 90.6d;
        public override double atomicWeight { get; } = 95.91451d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.6d, new List<RadioactiveSubstance> { new GammaParticle(0.02384), new Rhodium96() } },
            { 0.4d, new List<RadioactiveSubstance> { new BetaParticle(1, 6444390.0), new Ruthenium96() } },

        };
    }
}
    
    