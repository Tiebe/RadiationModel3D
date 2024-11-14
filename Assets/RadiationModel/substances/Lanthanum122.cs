using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Lanthanum122 : RadioactiveSubstance
    {
        public override string name { get; } = "Lanthanum122";
        public override double halfLife { get; } = 8.6d;
        public override double atomicWeight { get; } = 121.93071d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 10069000.0), new Barium122() } },

        };
    }
}
    
    