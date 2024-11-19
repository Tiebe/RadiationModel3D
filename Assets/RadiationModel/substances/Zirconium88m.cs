using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Zirconium88m : RadioactiveSubstance
    {
        public override string name { get; } = "Zirconium88m";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 87.91332d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(0.00043, 2888000.0), new Zirconium88() } },

        };
    }
}
    
    