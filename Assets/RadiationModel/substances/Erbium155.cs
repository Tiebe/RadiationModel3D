using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Erbium155 : RadioactiveSubstance
    {
        public override string name { get; } = "Erbium155";
        public override double halfLife { get; } = 318.0d;
        public override double atomicWeight { get; } = 154.93322d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.9997799999999999d, new List<RadioactiveSubstance> { new BetaParticle(1, 3831000.0), new Holmium155() } },
            { 0.00021999999999999998d, new List<RadioactiveSubstance> { new AlphaParticle(5140002.09), new Dysprosium151() } },

        };
    }
}
    
    