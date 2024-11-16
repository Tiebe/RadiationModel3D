using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Astatine207m : RadioactiveSubstance
    {
        public override string name { get; } = "Astatine207m";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 206.98807d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(0.00059), new Astatine207() } },

        };
    }
}
    
    