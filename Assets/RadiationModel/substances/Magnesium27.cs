
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Magnesium27 : RadioactiveSubstance
    {
        public override string name { get; } = "Magnesium27";
        public override double halfLife { get; } = 566.1d;
        public override double atomicWeight { get; } = 26.98434d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Aluminum27() } },

        };
    }
}
    
    