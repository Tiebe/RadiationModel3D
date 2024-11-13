
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Berkelium242 : RadioactiveSubstance
    {
        public override string name { get; } = "Berkelium242";
        public override double halfLife { get; } = 420.0d;
        public override double atomicWeight { get; } = 242.062d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Curium242() } },

        };
    }
}
    
    