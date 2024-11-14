using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Berkelium248m : RadioactiveSubstance
    {
        public override string name { get; } = "Berkelium248m";
        public override double halfLife { get; } = 85320.0d;
        public override double atomicWeight { get; } = 248.07312d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.7d, new List<RadioactiveSubstance> { new BetaParticle(-1, 870000.0), new Californium248() } },
            { 0.3d, new List<RadioactiveSubstance> { new Curium248() } },

        };
    }
}
    
    