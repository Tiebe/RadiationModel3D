
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Thulium158 : RadioactiveSubstance
    {
        public override string name { get; } = "Thulium158";
        public override double halfLife { get; } = 238.8d;
        public override double atomicWeight { get; } = 157.93698d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Erbium158() } },

        };
    }
}
    
    