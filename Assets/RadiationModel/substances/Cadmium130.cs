using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Cadmium130 : RadioactiveSubstance
    {
        public override string name { get; } = "Cadmium130";
        public override double halfLife { get; } = 0.1268d;
        public override double atomicWeight { get; } = 129.93439d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 8788500.0), new Indium130() } },

        };
    }
}
    
    