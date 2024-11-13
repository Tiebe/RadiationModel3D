
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Aluminum24m : RadioactiveSubstance
    {
        public override string name { get; } = "Aluminum24m";
        public override double halfLife { get; } = 0.13d;
        public override double atomicWeight { get; } = 24.0004d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 0.825d, new List<RadioactiveSubstance> { new GammaParticle(), new Aluminum24() } },

            { 0.175d, new List<RadioactiveSubstance> { new BetaParticle(), new Magnesium24() } },

        };
    }
}
    
    