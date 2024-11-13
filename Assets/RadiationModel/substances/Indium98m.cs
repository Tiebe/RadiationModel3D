
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Indium98m : RadioactiveSubstance
    {
        public override string name { get; } = "Indium98m";
        public override double halfLife { get; } = 0.89d;
        public override double atomicWeight { get; } = 97.94301d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Cadmium98() } },

        };
    }
}
    
    