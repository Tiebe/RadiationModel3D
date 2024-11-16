using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Tin115m : RadioactiveSubstance
    {
        public override string name { get; } = "Tin115m";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 114.904d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(0.00202), new Tin115() } },

        };
    }
}
    
    