using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Thallium183m : RadioactiveSubstance
    {
        public override string name { get; } = "Thallium183m";
        public override double halfLife { get; } = 0.0533d;
        public override double atomicWeight { get; } = 182.98287d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.015d, new List<RadioactiveSubstance> { new AlphaParticle(7627002.09), new Gold179() } },

        };
    }
}
    
    