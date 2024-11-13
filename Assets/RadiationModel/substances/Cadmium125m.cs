
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Cadmium125m : RadioactiveSubstance
    {
        public override string name { get; } = "Cadmium125m";
        public override double halfLife { get; } = 0.48d;
        public override double atomicWeight { get; } = 124.92146d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Indium125() } },

        };
    }
}
    
    