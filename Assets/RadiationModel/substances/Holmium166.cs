
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Holmium166 : RadioactiveSubstance
    {
        public override string name { get; } = "Holmium166";
        public override double halfLife { get; } = 96523.2d;
        public override double atomicWeight { get; } = 165.93229d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Erbium166() } },

        };
    }
}
    
    