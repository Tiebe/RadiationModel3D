
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Promethium154 : RadioactiveSubstance
    {
        public override string name { get; } = "Promethium154";
        public override double halfLife { get; } = 160.8d;
        public override double atomicWeight { get; } = 153.92671d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Samarium154() } },

        };
    }
}
    
    