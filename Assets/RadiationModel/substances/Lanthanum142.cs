
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Lanthanum142 : RadioactiveSubstance
    {
        public override string name { get; } = "Lanthanum142";
        public override double halfLife { get; } = 5466.0d;
        public override double atomicWeight { get; } = 141.91409d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Cerium142() } },

        };
    }
}
    
    