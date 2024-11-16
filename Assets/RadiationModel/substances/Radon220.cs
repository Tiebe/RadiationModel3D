using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Radon220 : RadioactiveSubstance
    {
        public override string name { get; } = "Radon220";
        public override double halfLife { get; } = 55.6d;
        public override double atomicWeight { get; } = 220.01139d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new AlphaParticle(7426702.09), new Polonium216() } },

        };
    }
}
    
    