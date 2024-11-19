using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Rhodium100m : RadioactiveSubstance
    {
        public override string name { get; } = "Rhodium100m";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 99.90819d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(0.01653, 75000.0), new Rhodium100() } },

        };
    }
}
    
    