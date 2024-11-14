using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Indium123p : RadioactiveSubstance
    {
        public override string name { get; } = "Indium123p";
        public override double halfLife { get; } = 0.0001d;
        public override double atomicWeight { get; } = 122.91269d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(0.00059), new Indium123() } },

        };
    }
}
    
    