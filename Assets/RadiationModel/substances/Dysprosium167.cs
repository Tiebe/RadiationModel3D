
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Dysprosium167 : RadioactiveSubstance
    {
        public override string name { get; } = "Dysprosium167";
        public override double halfLife { get; } = 372.0d;
        public override double atomicWeight { get; } = 166.93568d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Holmium167() } },

        };
    }
}
    
    