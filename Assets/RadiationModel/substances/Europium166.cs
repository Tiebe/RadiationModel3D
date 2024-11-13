
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Europium166 : RadioactiveSubstance
    {
        public override string name { get; } = "Europium166";
        public override double halfLife { get; } = 1.24d;
        public override double atomicWeight { get; } = 165.94981d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Gadolinium166() } },

        };
    }
}
    
    