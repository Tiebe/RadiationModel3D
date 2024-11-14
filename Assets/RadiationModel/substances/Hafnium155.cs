using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Hafnium155 : RadioactiveSubstance
    {
        public override string name { get; } = "Hafnium155";
        public override double halfLife { get; } = 0.843d;
        public override double atomicWeight { get; } = 154.96317d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 8235000.0), new Lutetium155() } },

        };
    }
}
    
    