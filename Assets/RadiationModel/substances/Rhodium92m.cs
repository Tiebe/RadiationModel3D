using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Rhodium92m : RadioactiveSubstance
    {
        public override string name { get; } = "Rhodium92m";
        public override double halfLife { get; } = 3.18d;
        public override double atomicWeight { get; } = 91.93242d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 11351200.0), new Ruthenium92() } },

        };
    }
}
    
    