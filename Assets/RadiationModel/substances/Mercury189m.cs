
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Mercury189m : RadioactiveSubstance
    {
        public override string name { get; } = "Mercury189m";
        public override double halfLife { get; } = 516.0d;
        public override double atomicWeight { get; } = 188.96828d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Gold189() } },

        };
    }
}
    
    