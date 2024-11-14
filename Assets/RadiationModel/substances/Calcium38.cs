using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Calcium38 : RadioactiveSubstance
    {
        public override string name { get; } = "Calcium38";
        public override double halfLife { get; } = 0.4437d;
        public override double atomicWeight { get; } = 37.97632d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 6742260.0), new Potassium38() } },

        };
    }
}
    
    