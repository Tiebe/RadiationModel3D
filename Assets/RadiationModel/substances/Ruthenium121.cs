
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Ruthenium121 : RadioactiveSubstance
    {
        public override string name { get; } = "Ruthenium121";
        public override double halfLife { get; } = 0.029d;
        public override double atomicWeight { get; } = 120.9521d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Rhodium121() } },

        };
    }
}
    
    