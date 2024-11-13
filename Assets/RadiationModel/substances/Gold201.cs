
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Gold201 : RadioactiveSubstance
    {
        public override string name { get; } = "Gold201";
        public override double halfLife { get; } = 1560.0d;
        public override double atomicWeight { get; } = 200.97166d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Mercury201() } },

        };
    }
}
    
    