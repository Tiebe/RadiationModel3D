using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Nihonium286 : RadioactiveSubstance
    {
        public override string name { get; } = "Nihonium286";
        public override double halfLife { get; } = 12.0d;
        public override double atomicWeight { get; } = 286.18246d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new AlphaParticle(10817002.09), new Roentgenium282() } },

        };
    }
}
    
    