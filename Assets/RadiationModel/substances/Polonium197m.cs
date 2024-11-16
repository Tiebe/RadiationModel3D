using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Polonium197m : RadioactiveSubstance
    {
        public override string name { get; } = "Polonium197m";
        public override double halfLife { get; } = 25.8d;
        public override double atomicWeight { get; } = 196.98583d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.84d, new List<RadioactiveSubstance> { new AlphaParticle(7629002.09), new Lead193() } },

        };
    }
}
    
    