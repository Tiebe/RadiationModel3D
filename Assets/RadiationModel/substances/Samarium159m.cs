using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Samarium159m : RadioactiveSubstance
    {
        public override string name { get; } = "Samarium159m";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 158.93459d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(0.00097, 1276000.0), new Samarium159() } },

        };
    }
}
    
    