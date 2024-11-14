using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Samarium151 : RadioactiveSubstance
    {
        public override string name { get; } = "Samarium151";
        public override double halfLife { get; } = 2985287659.2d;
        public override double atomicWeight { get; } = 150.91994d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 76600.0), new Europium151() } },

        };
    }
}
    
    