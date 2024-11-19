using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Osmium191m : RadioactiveSubstance
    {
        public override string name { get; } = "Osmium191m";
        public override double halfLife { get; } = 47160.0d;
        public override double atomicWeight { get; } = 190.96101d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(0.01666, 74400.0), new Osmium191() } },

        };
    }
}
    
    