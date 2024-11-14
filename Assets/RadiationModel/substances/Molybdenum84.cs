using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Molybdenum84 : RadioactiveSubstance
    {
        public override string name { get; } = "Molybdenum84";
        public override double halfLife { get; } = 2.3d;
        public override double atomicWeight { get; } = 83.94185d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 7023800.0), new Niobium84() } },

        };
    }
}
    
    