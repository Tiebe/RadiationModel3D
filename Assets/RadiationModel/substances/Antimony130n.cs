using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Antimony130n : RadioactiveSubstance
    {
        public override string name { get; } = "Antimony130n";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 129.91175d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(0.01459), new Antimony130() } },

        };
    }
}
    
    