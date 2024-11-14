using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Indium121m : RadioactiveSubstance
    {
        public override string name { get; } = "Indium121m";
        public override double halfLife { get; } = 232.8d;
        public override double atomicWeight { get; } = 120.90819d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.988d, new List<RadioactiveSubstance> { new BetaParticle(-1, 3675600.0), new Tin121() } },
            { 0.012d, new List<RadioactiveSubstance> { new GammaParticle(0.00395), new Indium121() } },

        };
    }
}
    
    