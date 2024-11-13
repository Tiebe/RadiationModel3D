
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Bismuth194m : RadioactiveSubstance
    {
        public override string name { get; } = "Bismuth194m";
        public override double halfLife { get; } = 125.0d;
        public override double atomicWeight { get; } = 193.98295d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Lead194() } },

        };
    }
}
    
    