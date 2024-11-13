
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Cadmium115m : RadioactiveSubstance
    {
        public override string name { get; } = "Cadmium115m";
        public override double halfLife { get; } = 3849984.0d;
        public override double atomicWeight { get; } = 114.90563d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Indium115() } },

        };
    }
}
    
    