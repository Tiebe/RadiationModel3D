using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Mercury205m : RadioactiveSubstance
    {
        public override string name { get; } = "Mercury205m";
        public override double halfLife { get; } = 0.00109d;
        public override double atomicWeight { get; } = 204.97774d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(0.0008, 1556000.0), new Mercury205() } },

        };
    }
}
    
    