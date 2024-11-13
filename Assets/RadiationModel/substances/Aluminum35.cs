
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Aluminum35 : RadioactiveSubstance
    {
        public override string name { get; } = "Aluminum35";
        public override double halfLife { get; } = 0.03816d;
        public override double atomicWeight { get; } = 34.99976d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Silicon35() } },

        };
    }
}
    
    