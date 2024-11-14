using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Rhenium177 : RadioactiveSubstance
    {
        public override string name { get; } = "Rhenium177";
        public override double halfLife { get; } = 840.0d;
        public override double atomicWeight { get; } = 176.95033d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 3433000.0), new Tungsten177() } },

        };
    }
}
    
    