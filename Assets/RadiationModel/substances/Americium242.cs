using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Americium242 : RadioactiveSubstance
    {
        public override string name { get; } = "Americium242";
        public override double halfLife { get; } = 57672.0d;
        public override double atomicWeight { get; } = 242.05955d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.8270000000000001d, new List<RadioactiveSubstance> { new BetaParticle(-1, 664300.0), new Curium242() } },
            { 0.17300000000000001d, new List<RadioactiveSubstance> { new Plutonium242() } },

        };
    }
}
    
    