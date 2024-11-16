using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Potassium53 : RadioactiveSubstance
    {
        public override string name { get; } = "Potassium53";
        public override double halfLife { get; } = 0.03d;
        public override double atomicWeight { get; } = 52.9868d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 17090000.0), new Calcium53() } },

        };
    }
}
    
    