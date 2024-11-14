using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Nickel51 : RadioactiveSubstance
    {
        public override string name { get; } = "Nickel51";
        public override double halfLife { get; } = 0.0238d;
        public override double atomicWeight { get; } = 50.98749d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 15690000.0), new Cobalt51() } },

        };
    }
}
    
    