using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Indium106m : RadioactiveSubstance
    {
        public override string name { get; } = "Indium106m";
        public override double halfLife { get; } = 312.0d;
        public override double atomicWeight { get; } = 105.91349d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 6553200.0), new Cadmium106() } },

        };
    }
}
    
    