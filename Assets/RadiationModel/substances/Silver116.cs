
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Silver116 : RadioactiveSubstance
    {
        public override string name { get; } = "Silver116";
        public override double halfLife { get; } = 229.8d;
        public override double atomicWeight { get; } = 115.91139d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Cadmium116() } },

        };
    }
}
    
    