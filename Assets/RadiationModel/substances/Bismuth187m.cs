
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Bismuth187m : RadioactiveSubstance
    {
        public override string name { get; } = "Bismuth187m";
        public override double halfLife { get; } = 0.00037d;
        public override double atomicWeight { get; } = 186.99326d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new AlphaParticle(), new Thallium183() } },

        };
    }
}
    
    