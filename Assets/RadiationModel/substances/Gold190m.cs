
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Gold190m : RadioactiveSubstance
    {
        public override string name { get; } = "Gold190m";
        public override double halfLife { get; } = 0.125d;
        public override double atomicWeight { get; } = 189.96497d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(), new Gold190() } },

        };
    }
}
    
    