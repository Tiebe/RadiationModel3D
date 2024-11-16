using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Potassium40 : RadioactiveSubstance
    {
        public override string name { get; } = "Potassium40";
        public override double halfLife { get; } = 3.9383076096e+16d;
        public override double atomicWeight { get; } = 39.964d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.8928d, new List<RadioactiveSubstance> { new BetaParticle(-1, 1310902.0), new Calcium40() } },
            { 0.1072d, new List<RadioactiveSubstance> { new BetaParticle(1, 1504400.0), new Argon40() } },

        };
    }
}
    
    