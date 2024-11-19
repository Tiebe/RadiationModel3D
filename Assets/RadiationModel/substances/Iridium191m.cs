using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Iridium191m : RadioactiveSubstance
    {
        public override string name { get; } = "Iridium191m";
        public override double halfLife { get; } = 4.899d;
        public override double atomicWeight { get; } = 190.96078d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(0.00724, 171300.0), new Iridium191() } },

        };
    }
}
    
    