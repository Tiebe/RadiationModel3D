using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Cerium145 : RadioactiveSubstance
    {
        public override string name { get; } = "Cerium145";
        public override double halfLife { get; } = 180.6d;
        public override double atomicWeight { get; } = 144.91726d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 2556000.0), new Praseodymium145() } },

        };
    }
}
    
    