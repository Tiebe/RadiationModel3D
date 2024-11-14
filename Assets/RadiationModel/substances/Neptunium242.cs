using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Neptunium242 : RadioactiveSubstance
    {
        public override string name { get; } = "Neptunium242";
        public override double halfLife { get; } = 132.0d;
        public override double atomicWeight { get; } = 242.06164d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 2703100.0), new Plutonium242() } },

        };
    }
}
    
    