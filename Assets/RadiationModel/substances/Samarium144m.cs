using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Samarium144m : RadioactiveSubstance
    {
        public override string name { get; } = "Samarium144m";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 143.9145d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(0.00053, 2323600.0), new Samarium144() } },

        };
    }
}
    
    