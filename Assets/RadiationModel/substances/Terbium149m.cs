using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Terbium149m : RadioactiveSubstance
    {
        public override string name { get; } = "Terbium149m";
        public override double halfLife { get; } = 249.6d;
        public override double atomicWeight { get; } = 148.92329d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 3674000.0), new Gadolinium149() } },
            { 0.00021999999999999998d, new List<RadioactiveSubstance> { new AlphaParticle(5134047.4), new Europium145() } },

        };
    }
}
    
    