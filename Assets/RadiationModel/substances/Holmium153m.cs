using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Holmium153m : RadioactiveSubstance
    {
        public override string name { get; } = "Holmium153m";
        public override double halfLife { get; } = 558.0d;
        public override double atomicWeight { get; } = 152.93028d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.9982d, new List<RadioactiveSubstance> { new BetaParticle(1, 4200000.0), new Dysprosium153() } },
            { 0.0018d, new List<RadioactiveSubstance> { new AlphaParticle(5143002.09), new Terbium149() } },

        };
    }
}
    
    