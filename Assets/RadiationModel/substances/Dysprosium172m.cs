using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Dysprosium172m : RadioactiveSubstance
    {
        public override string name { get; } = "Dysprosium172m";
        public override double halfLife { get; } = 0.71d;
        public override double atomicWeight { get; } = 171.9501d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.19d, new List<RadioactiveSubstance> { new BetaParticle(-1, 5000000.0), new Holmium172() } },
            { 0.81d, new List<RadioactiveSubstance> { new GammaParticle(0.00097), new Dysprosium172() } },

        };
    }
}
    
    