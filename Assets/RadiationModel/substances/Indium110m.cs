
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Indium110m : RadioactiveSubstance
    {
        public override string name { get; } = "Indium110m";
        public override double halfLife { get; } = 4146.0d;
        public override double atomicWeight { get; } = 109.90724d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Cadmium110() } },

        };
    }
}
    
    