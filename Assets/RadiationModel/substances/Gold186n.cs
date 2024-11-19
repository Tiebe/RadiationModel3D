using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Gold186n : RadioactiveSubstance
    {
        public override string name { get; } = "Gold186n";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 185.9662d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle((228000.0, 0.00544)), new Gold186() } },

        };
    }
}
    
    