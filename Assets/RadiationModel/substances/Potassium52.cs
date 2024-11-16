using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Potassium52 : RadioactiveSubstance
    {
        public override string name { get; } = "Potassium52";
        public override double halfLife { get; } = 0.11d;
        public override double atomicWeight { get; } = 51.9816d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 17126300.0), new Calcium52() } },

        };
    }
}
    
    