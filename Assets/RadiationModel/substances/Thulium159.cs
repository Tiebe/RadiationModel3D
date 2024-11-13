
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Thulium159 : RadioactiveSubstance
    {
        public override string name { get; } = "Thulium159";
        public override double halfLife { get; } = 547.8d;
        public override double atomicWeight { get; } = 158.93498d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Erbium159() } },

        };
    }
}
    
    