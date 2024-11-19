using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Holmium163m : RadioactiveSubstance
    {
        public override string name { get; } = "Holmium163m";
        public override double halfLife { get; } = 1.09d;
        public override double atomicWeight { get; } = 162.92906d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(0.00416, 297900.0), new Holmium163() } },

        };
    }
}
    
    