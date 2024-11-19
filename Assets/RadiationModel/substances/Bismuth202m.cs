using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Bismuth202m : RadioactiveSubstance
    {
        public override string name { get; } = "Bismuth202m";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 201.97839d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(0.00198, 625000.0), new Bismuth202() } },

        };
    }
}
    
    