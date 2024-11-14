using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Zirconium90m : RadioactiveSubstance
    {
        public override string name { get; } = "Zirconium90m";
        public override double halfLife { get; } = 0.8092d;
        public override double atomicWeight { get; } = 89.90719d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(0.00053), new Zirconium90() } },

        };
    }
}
    
    