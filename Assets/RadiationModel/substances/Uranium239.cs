using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Uranium239 : RadioactiveSubstance
    {
        public override string name { get; } = "Uranium239";
        public override double halfLife { get; } = 1407.0d;
        public override double atomicWeight { get; } = 239.05429d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 1261700.0), new Neptunium239() } },

        };
    }
}
    
    