
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Dysprosium166 : RadioactiveSubstance
    {
        public override string name { get; } = "Dysprosium166";
        public override double halfLife { get; } = 293760.0d;
        public override double atomicWeight { get; } = 165.93281d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Holmium166() } },

        };
    }
}
    
    