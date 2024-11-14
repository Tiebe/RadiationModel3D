using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Thulium153 : RadioactiveSubstance
    {
        public override string name { get; } = "Thulium153";
        public override double halfLife { get; } = 1.48d;
        public override double atomicWeight { get; } = 152.94206d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.91d, new List<RadioactiveSubstance> { new AlphaParticle(6268047.4), new Holmium149() } },
            { 0.09d, new List<RadioactiveSubstance> { new BetaParticle(1, 6494000.0), new Erbium153() } },

        };
    }
}
    
    