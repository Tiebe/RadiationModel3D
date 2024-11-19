using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Gold187m : RadioactiveSubstance
    {
        public override string name { get; } = "Gold187m";
        public override double halfLife { get; } = 2.3d;
        public override double atomicWeight { get; } = 186.96467d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(0.01033, 120000.0), new Gold187() } },

        };
    }
}
    
    