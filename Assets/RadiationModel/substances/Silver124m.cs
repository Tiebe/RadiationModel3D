
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Silver124m : RadioactiveSubstance
    {
        public override string name { get; } = "Silver124m";
        public override double halfLife { get; } = 0.144d;
        public override double atomicWeight { get; } = 123.92895d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Cadmium124() } },

        };
    }
}
    
    