
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Barium154 : RadioactiveSubstance
    {
        public override string name { get; } = "Barium154";
        public override double halfLife { get; } = 0.053d;
        public override double atomicWeight { get; } = 153.96466d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Lanthanum154() } },

        };
    }
}
    
    