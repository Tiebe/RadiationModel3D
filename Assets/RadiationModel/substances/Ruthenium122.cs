using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Ruthenium122 : RadioactiveSubstance
    {
        public override string name { get; } = "Ruthenium122";
        public override double halfLife { get; } = 0.025d;
        public override double atomicWeight { get; } = 121.95515d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 10100000.0), new Rhodium122() } },

        };
    }
}
    
    