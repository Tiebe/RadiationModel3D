using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Erbium149 : RadioactiveSubstance
    {
        public override string name { get; } = "Erbium149";
        public override double halfLife { get; } = 4.0d;
        public override double atomicWeight { get; } = 148.94231d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 7904000.0), new Holmium149() } },

        };
    }
}
    
    