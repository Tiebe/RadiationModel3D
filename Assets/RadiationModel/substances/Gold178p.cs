using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Gold178p : RadioactiveSubstance
    {
        public override string name { get; } = "Gold178p";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 177.97632d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(0.0051), new Gold178() } },

        };
    }
}
    
    