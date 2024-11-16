using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Neptunium231 : RadioactiveSubstance
    {
        public override string name { get; } = "Neptunium231";
        public override double halfLife { get; } = 2928.0d;
        public override double atomicWeight { get; } = 231.03824d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.98d, new List<RadioactiveSubstance> { new BetaParticle(1, 1814000.0), new Uranium231() } },
            { 0.02d, new List<RadioactiveSubstance> { new AlphaParticle(7387002.09), new Protactinium227() } },

        };
    }
}
    
    