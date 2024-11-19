using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Platinum191n : RadioactiveSubstance
    {
        public override string name { get; } = "Platinum191n";
        public override double halfLife { get; } = 0.0001d;
        public override double atomicWeight { get; } = 190.96184d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(0.00832, 149000.0), new Platinum191() } },

        };
    }
}
    
    