
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Europium159 : RadioactiveSubstance
    {
        public override string name { get; } = "Europium159";
        public override double halfLife { get; } = 1086.0d;
        public override double atomicWeight { get; } = 158.9291d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Gadolinium159() } },

        };
    }
}
    
    