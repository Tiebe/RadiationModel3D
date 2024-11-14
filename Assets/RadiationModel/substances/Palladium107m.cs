using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Palladium107m : RadioactiveSubstance
    {
        public override string name { get; } = "Palladium107m";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 106.90525d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(0.01072), new Palladium107() } },

        };
    }
}
    
    