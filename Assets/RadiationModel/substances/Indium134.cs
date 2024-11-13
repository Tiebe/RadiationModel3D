
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Indium134 : RadioactiveSubstance
    {
        public override string name { get; } = "Indium134";
        public override double halfLife { get; } = 0.136d;
        public override double atomicWeight { get; } = 133.94421d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Tin134() } },

        };
    }
}
    
    