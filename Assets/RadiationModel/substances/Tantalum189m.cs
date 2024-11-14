using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Tantalum189m : RadioactiveSubstance
    {
        public override string name { get; } = "Tantalum189m";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 188.96746d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(0.00075), new Tantalum189() } },

        };
    }
}
    
    