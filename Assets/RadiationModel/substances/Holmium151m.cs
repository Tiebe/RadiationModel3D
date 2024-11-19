using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Holmium151m : RadioactiveSubstance
    {
        public override string name { get; } = "Holmium151m";
        public override double halfLife { get; } = 47.2d;
        public override double atomicWeight { get; } = 150.93174d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.77d, new List<RadioactiveSubstance> { new AlphaParticle(5758002.09), new Terbium147() } },
            { 0.23d, new List<RadioactiveSubstance> { new BetaParticle(1, 5170000.0), new Dysprosium151() } },

        };
    }
}
    
    