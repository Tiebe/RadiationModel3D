
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Indium120 : RadioactiveSubstance
    {
        public override string name { get; } = "Indium120";
        public override double halfLife { get; } = 3.08d;
        public override double atomicWeight { get; } = 119.90797d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Tin120() } },

        };
    }
}
    
    