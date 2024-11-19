using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Bismuth191 : RadioactiveSubstance
    {
        public override string name { get; } = "Bismuth191";
        public override double halfLife { get; } = 12.4d;
        public override double atomicWeight { get; } = 190.98579d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.51d, new List<RadioactiveSubstance> { new AlphaParticle(7803002.09), new Thallium187() } },

        };
    }
}
    
    