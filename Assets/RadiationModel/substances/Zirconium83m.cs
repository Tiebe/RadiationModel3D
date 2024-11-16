using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Zirconium83m : RadioactiveSubstance
    {
        public override string name { get; } = "Zirconium83m";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 82.9293d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(0.02339), new Zirconium83() } },

        };
    }
}
    
    