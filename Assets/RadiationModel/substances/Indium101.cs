using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Indium101 : RadioactiveSubstance
    {
        public override string name { get; } = "Indium101";
        public override double halfLife { get; } = 15.1d;
        public override double atomicWeight { get; } = 100.92641d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 7291500.0), new Cadmium101() } },

        };
    }
}
    
    