using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Curium236 : RadioactiveSubstance
    {
        public override string name { get; } = "Curium236";
        public override double halfLife { get; } = 408.0d;
        public override double atomicWeight { get; } = 236.05137d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.82d, new List<RadioactiveSubstance> { new BetaParticle(1, 1813000.0), new Americium236() } },
            { 0.18d, new List<RadioactiveSubstance> { new AlphaParticle(8087047.4), new Plutonium232() } },

        };
    }
}
    
    