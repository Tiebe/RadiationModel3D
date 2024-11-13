
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Bismuth212m : RadioactiveSubstance
    {
        public override string name { get; } = "Bismuth212m";
        public override double halfLife { get; } = 1500.0d;
        public override double atomicWeight { get; } = 211.99155d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 0.67d, new List<RadioactiveSubstance> { new AlphaParticle(), new Thallium208() } },

            { 0.33d, new List<RadioactiveSubstance> { new BetaParticle(), new Polonium212() } },

        };
    }
}
    
    