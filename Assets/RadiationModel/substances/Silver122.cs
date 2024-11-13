
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Silver122 : RadioactiveSubstance
    {
        public override string name { get; } = "Silver122";
        public override double halfLife { get; } = 0.529d;
        public override double atomicWeight { get; } = 121.92366d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Cadmium122() } },

        };
    }
}
    
    