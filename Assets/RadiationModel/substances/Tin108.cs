using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Tin108 : RadioactiveSubstance
    {
        public override string name { get; } = "Tin108";
        public override double halfLife { get; } = 618.0d;
        public override double atomicWeight { get; } = 107.91189d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 2050000.0), new Indium108() } },

        };
    }
}
    
    