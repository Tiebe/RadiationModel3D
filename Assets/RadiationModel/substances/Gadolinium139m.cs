using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Gadolinium139m : RadioactiveSubstance
    {
        public override string name { get; } = "Gadolinium139m";
        public override double halfLife { get; } = 4.8d;
        public override double atomicWeight { get; } = 138.9384d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 8018000.0), new Europium139() } },

        };
    }
}
    
    