
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Gold196 : RadioactiveSubstance
    {
        public override string name { get; } = "Gold196";
        public override double halfLife { get; } = 532656.0d;
        public override double atomicWeight { get; } = 195.96657d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 0.93d, new List<RadioactiveSubstance> { new BetaParticle(), new Platinum196() } },

            { 0.07d, new List<RadioactiveSubstance> { new BetaParticle(), new Mercury196() } },

        };
    }
}
    
    