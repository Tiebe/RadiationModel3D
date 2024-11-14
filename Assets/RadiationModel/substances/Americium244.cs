using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Americium244 : RadioactiveSubstance
    {
        public override string name { get; } = "Americium244";
        public override double halfLife { get; } = 36036.0d;
        public override double atomicWeight { get; } = 244.06428d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 1427300.0), new Curium244() } },

        };
    }
}
    
    