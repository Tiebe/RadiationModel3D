
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Gold196n : RadioactiveSubstance
    {
        public override string name { get; } = "Gold196n";
        public override double halfLife { get; } = 34570.8d;
        public override double atomicWeight { get; } = 195.96721d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(), new Gold196() } },

        };
    }
}
    
    