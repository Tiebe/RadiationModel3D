
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

            { 0.988d, new List<RadioactiveSubstance> { new BetaParticle(), new Tin121() } },

            { 0.012d, new List<RadioactiveSubstance> { new GammaParticle(), new Indium121() } },

        };
    }
}
    
    