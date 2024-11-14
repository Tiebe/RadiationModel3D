using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Nihonium278 : RadioactiveSubstance
    {
        public override string name { get; } = "Nihonium278";
        public override double halfLife { get; } = 0.0023d;
        public override double atomicWeight { get; } = 278.17073d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new AlphaParticle(13015047.4), new Roentgenium274() } },

        };
    }
}
    
    