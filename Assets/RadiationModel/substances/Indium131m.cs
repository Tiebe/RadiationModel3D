using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Indium131m : RadioactiveSubstance
    {
        public override string name { get; } = "Indium131m";
        public override double halfLife { get; } = 0.328d;
        public override double atomicWeight { get; } = 130.92738d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 9616600.0), new Tin131() } },

        };
    }
}
    
    