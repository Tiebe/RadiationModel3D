
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Tellurium121m : RadioactiveSubstance
    {
        public override string name { get; } = "Tellurium121m";
        public override double halfLife { get; } = 14230080.0d;
        public override double atomicWeight { get; } = 120.90526d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 0.8859999999999999d, new List<RadioactiveSubstance> { new GammaParticle(), new Tellurium121() } },

            { 0.114d, new List<RadioactiveSubstance> { new BetaParticle(), new Antimony121() } },

        };
    }
}
    
    