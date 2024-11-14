using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Neptunium237m : RadioactiveSubstance
    {
        public override string name { get; } = "Neptunium237m";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 237.04919d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(0.00131), new Neptunium237() } },

        };
    }
}
    
    