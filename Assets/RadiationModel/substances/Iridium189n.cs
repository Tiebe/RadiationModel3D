using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Iridium189n : RadioactiveSubstance
    {
        public override string name { get; } = "Iridium189n";
        public override double halfLife { get; } = 0.0037d;
        public override double atomicWeight { get; } = 188.96123d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(0.00053, 2333000.0), new Iridium189() } },

        };
    }
}
    
    