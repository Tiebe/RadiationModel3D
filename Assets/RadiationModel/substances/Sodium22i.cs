using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Sodium22i : RadioactiveSubstance
    {
        public override string name { get; } = "Sodium22i";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 21.99514d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(0.00189, 657000.0), new Sodium22() } },

        };
    }
}
    
    