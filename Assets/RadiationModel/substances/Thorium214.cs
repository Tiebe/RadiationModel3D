using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Thorium214 : RadioactiveSubstance
    {
        public override string name { get; } = "Thorium214";
        public override double halfLife { get; } = 0.087d;
        public override double atomicWeight { get; } = 214.01148d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new AlphaParticle(8847047.4), new Radium210() } },

        };
    }
}
    
    