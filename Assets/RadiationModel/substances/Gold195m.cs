
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Gold195m : RadioactiveSubstance
    {
        public override string name { get; } = "Gold195m";
        public override double halfLife { get; } = 30.5d;
        public override double atomicWeight { get; } = 194.96538d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(), new Gold195() } },

        };
    }
}
    
    