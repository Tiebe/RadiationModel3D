using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Rhenium172m : RadioactiveSubstance
    {
        public override string name { get; } = "Rhenium172m";
        public override double halfLife { get; } = 15.0d;
        public override double atomicWeight { get; } = 171.95549d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 7637000.0), new Tungsten172() } },

        };
    }
}
    
    