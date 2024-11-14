using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Americium244m : RadioactiveSubstance
    {
        public override string name { get; } = "Americium244m";
        public override double halfLife { get; } = 1567.8d;
        public override double atomicWeight { get; } = 244.06438d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.999636d, new List<RadioactiveSubstance> { new BetaParticle(-1, 1516600.0), new Curium244() } },
            { 0.000364d, new List<RadioactiveSubstance> { new Plutonium244() } },

        };
    }
}
    
    