using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Nickel63m : RadioactiveSubstance
    {
        public override string name { get; } = "Nickel63m";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 62.92976d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(0.01423), new Nickel63() } },

        };
    }
}
    
    