using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Ruthenium103 : RadioactiveSubstance
    {
        public override string name { get; } = "Ruthenium103";
        public override double halfLife { get; } = 3390768.0d;
        public override double atomicWeight { get; } = 102.90631d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 764500.0), new Rhodium103() } },

        };
    }
}
    
    