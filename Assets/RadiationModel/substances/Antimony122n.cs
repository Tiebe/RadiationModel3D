using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Antimony122n : RadioactiveSubstance
    {
        public override string name { get; } = "Antimony122n";
        public override double halfLife { get; } = 0.00053d;
        public override double atomicWeight { get; } = 121.90532d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(0.00902), new Antimony122() } },

        };
    }
}
    
    