using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Lanthanum154 : RadioactiveSubstance
    {
        public override string name { get; } = "Lanthanum154";
        public override double halfLife { get; } = 0.161d;
        public override double atomicWeight { get; } = 153.95542d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 10690000.0), new Cerium154() } },

        };
    }
}
    
    