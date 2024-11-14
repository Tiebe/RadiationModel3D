using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Osmium192m : RadioactiveSubstance
    {
        public override string name { get; } = "Osmium192m";
        public override double halfLife { get; } = 5.94d;
        public override double atomicWeight { get; } = 191.96364d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(0.00062), new Osmium192() } },

        };
    }
}
    
    