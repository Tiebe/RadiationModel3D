using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Nihonium284 : RadioactiveSubstance
    {
        public override string name { get; } = "Nihonium284";
        public override double halfLife { get; } = 0.97d;
        public override double atomicWeight { get; } = 284.17884d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new AlphaParticle(11297002.09), new Roentgenium280() } },

        };
    }
}
    
    