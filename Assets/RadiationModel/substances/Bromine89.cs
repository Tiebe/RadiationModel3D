using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Bromine89 : RadioactiveSubstance
    {
        public override string name { get; } = "Bromine89";
        public override double halfLife { get; } = 4.357d;
        public override double atomicWeight { get; } = 88.9267d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 8261799.999999999), new Krypton89() } },

        };
    }
}
    
    