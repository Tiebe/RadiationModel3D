using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Mercury186 : RadioactiveSubstance
    {
        public override string name { get; } = "Mercury186";
        public override double halfLife { get; } = 82.8d;
        public override double atomicWeight { get; } = 185.96936d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 3176000.0), new Gold186() } },
            { 0.00016d, new List<RadioactiveSubstance> { new AlphaParticle(6226002.09), new Platinum182() } },

        };
    }
}
    
    