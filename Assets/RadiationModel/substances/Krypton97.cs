
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Krypton97 : RadioactiveSubstance
    {
        public override string name { get; } = "Krypton97";
        public override double halfLife { get; } = 0.0622d;
        public override double atomicWeight { get; } = 96.94909d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Rubidium97() } },

        };
    }
}
    
    