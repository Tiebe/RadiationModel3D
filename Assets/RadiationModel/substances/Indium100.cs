using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Indium100 : RadioactiveSubstance
    {
        public override string name { get; } = "Indium100";
        public override double halfLife { get; } = 5.62d;
        public override double atomicWeight { get; } = 99.9311d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 10016500.0), new Cadmium100() } },

        };
    }
}
    
    