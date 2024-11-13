
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Bismuth198m : RadioactiveSubstance
    {
        public override string name { get; } = "Bismuth198m";
        public override double halfLife { get; } = 696.0d;
        public override double atomicWeight { get; } = 197.97951d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Lead198() } },

        };
    }
}
    
    