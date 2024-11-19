using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Vanadium47i : RadioactiveSubstance
    {
        public override string name { get; } = "Vanadium47i";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 46.95936d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(0.0003, 4150350.0000000005), new Vanadium47() } },

        };
    }
}
    
    