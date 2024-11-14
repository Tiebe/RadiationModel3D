using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Terbium151 : RadioactiveSubstance
    {
        public override string name { get; } = "Terbium151";
        public override double halfLife { get; } = 63392.4d;
        public override double atomicWeight { get; } = 150.92311d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.9999049999999999d, new List<RadioactiveSubstance> { new BetaParticle(1, 2564900.0), new Gadolinium151() } },
            { 9.499999999999999e-05d, new List<RadioactiveSubstance> { new AlphaParticle(4515647.399999999), new Europium147() } },

        };
    }
}
    
    