using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Cadmium126 : RadioactiveSubstance
    {
        public override string name { get; } = "Cadmium126";
        public override double halfLife { get; } = 0.512d;
        public override double atomicWeight { get; } = 125.92243d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 5553300.0), new Indium126() } },

        };
    }
}
    
    