using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Gadolinium139 : RadioactiveSubstance
    {
        public override string name { get; } = "Gadolinium139";
        public override double halfLife { get; } = 5.7d;
        public override double atomicWeight { get; } = 138.93813d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 7768000.0), new Europium139() } },

        };
    }
}
    
    