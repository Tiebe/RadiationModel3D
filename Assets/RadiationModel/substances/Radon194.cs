using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Radon194 : RadioactiveSubstance
    {
        public override string name { get; } = "Radon194";
        public override double halfLife { get; } = 0.00078d;
        public override double atomicWeight { get; } = 194.00615d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new AlphaParticle(8885002.09), new Polonium190() } },

        };
    }
}
    
    