using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Polonium191m : RadioactiveSubstance
    {
        public override string name { get; } = "Polonium191m";
        public override double halfLife { get; } = 0.093d;
        public override double atomicWeight { get; } = 190.99462d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new AlphaParticle(8574047.4), new Lead187() } },

        };
    }
}
    
    