using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Indium107m : RadioactiveSubstance
    {
        public override string name { get; } = "Indium107m";
        public override double halfLife { get; } = 50.4d;
        public override double atomicWeight { get; } = 106.91101d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(0.00183, 678000.0), new Indium107() } },

        };
    }
}
    
    