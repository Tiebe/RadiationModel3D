using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Tungsten162 : RadioactiveSubstance
    {
        public override string name { get; } = "Tungsten162";
        public override double halfLife { get; } = 1.19d;
        public override double atomicWeight { get; } = 161.9635d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.452d, new List<RadioactiveSubstance> { new AlphaParticle(6698047.4), new Hafnium158() } },

        };
    }
}
    
    