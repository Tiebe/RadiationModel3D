
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Antimony124m : RadioactiveSubstance
    {
        public override string name { get; } = "Antimony124m";
        public override double halfLife { get; } = 93.0d;
        public override double atomicWeight { get; } = 123.90595d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 0.75d, new List<RadioactiveSubstance> { new GammaParticle(), new Antimony124() } },

            { 0.25d, new List<RadioactiveSubstance> { new BetaParticle(), new Tellurium124() } },

        };
    }
}
    
    