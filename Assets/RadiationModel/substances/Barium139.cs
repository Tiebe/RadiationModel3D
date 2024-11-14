using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Barium139 : RadioactiveSubstance
    {
        public override string name { get; } = "Barium139";
        public override double halfLife { get; } = 4975.8d;
        public override double atomicWeight { get; } = 138.90884d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 2308480.0), new Lanthanum139() } },

        };
    }
}
    
    