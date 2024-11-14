using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Niobium100 : RadioactiveSubstance
    {
        public override string name { get; } = "Niobium100";
        public override double halfLife { get; } = 1.5d;
        public override double atomicWeight { get; } = 99.91434d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 6402000.0), new Molybdenum100() } },

        };
    }
}
    
    