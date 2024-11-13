
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Calcium47 : RadioactiveSubstance
    {
        public override string name { get; } = "Calcium47";
        public override double halfLife { get; } = 391910.4d;
        public override double atomicWeight { get; } = 46.95454d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Scandium47() } },

        };
    }
}
    
    