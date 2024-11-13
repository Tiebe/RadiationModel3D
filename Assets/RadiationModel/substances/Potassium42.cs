
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Potassium42 : RadioactiveSubstance
    {
        public override string name { get; } = "Potassium42";
        public override double halfLife { get; } = 44478.0d;
        public override double atomicWeight { get; } = 41.9624d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Calcium42() } },

        };
    }
}
    
    