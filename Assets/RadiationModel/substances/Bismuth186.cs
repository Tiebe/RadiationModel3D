using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Bismuth186 : RadioactiveSubstance
    {
        public override string name { get; } = "Bismuth186";
        public override double halfLife { get; } = 0.0148d;
        public override double atomicWeight { get; } = 185.99662d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new AlphaParticle(8779002.09), new Thallium182() } },

        };
    }
}
    
    