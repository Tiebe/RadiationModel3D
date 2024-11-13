
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Silver116n : RadioactiveSubstance
    {
        public override string name { get; } = "Silver116n";
        public override double halfLife { get; } = 9.3d;
        public override double atomicWeight { get; } = 115.91153d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 0.92d, new List<RadioactiveSubstance> { new BetaParticle(), new Cadmium116() } },

            { 0.08d, new List<RadioactiveSubstance> { new GammaParticle(), new Silver116() } },

        };
    }
}
    
    