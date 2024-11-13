
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Mercury187 : RadioactiveSubstance
    {
        public override string name { get; } = "Mercury187";
        public override double halfLife { get; } = 114.0d;
        public override double atomicWeight { get; } = 186.96981d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Gold187() } },

        };
    }
}
    
    