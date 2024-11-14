using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Molybdenum83 : RadioactiveSubstance
    {
        public override string name { get; } = "Molybdenum83";
        public override double halfLife { get; } = 0.023d;
        public override double atomicWeight { get; } = 82.95025d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 11270000.0), new Niobium83() } },

        };
    }
}
    
    