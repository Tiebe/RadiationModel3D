using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Californium243 : RadioactiveSubstance
    {
        public override string name { get; } = "Californium243";
        public override double halfLife { get; } = 648.0d;
        public override double atomicWeight { get; } = 243.06548d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.86d, new List<RadioactiveSubstance> { new BetaParticle(1, 2300000.0), new Berkelium243() } },
            { 0.14d, new List<RadioactiveSubstance> { new AlphaParticle(8437002.09), new Curium239() } },

        };
    }
}
    
    