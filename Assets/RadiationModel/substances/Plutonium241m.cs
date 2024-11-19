using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Plutonium241m : RadioactiveSubstance
    {
        public override string name { get; } = "Plutonium241m";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 241.05702d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(0.00767, 161700.0), new Plutonium241() } },

        };
    }
}
    
    