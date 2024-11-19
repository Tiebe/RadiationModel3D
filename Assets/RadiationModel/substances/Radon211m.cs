using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Radon211m : RadioactiveSubstance
    {
        public override string name { get; } = "Radon211m";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 210.99232d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(0.00077, 1603000.0), new Radon211() } },

        };
    }
}
    
    