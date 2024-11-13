
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Erbium159 : RadioactiveSubstance
    {
        public override string name { get; } = "Erbium159";
        public override double halfLife { get; } = 2160.0d;
        public override double atomicWeight { get; } = 158.93069d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Holmium159() } },

        };
    }
}
    
    