
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Aluminum28 : RadioactiveSubstance
    {
        public override string name { get; } = "Aluminum28";
        public override double halfLife { get; } = 134.7d;
        public override double atomicWeight { get; } = 27.98191d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Silicon28() } },

        };
    }
}
    
    