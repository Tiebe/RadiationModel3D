using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Radon197m : RadioactiveSubstance
    {
        public override string name { get; } = "Radon197m";
        public override double halfLife { get; } = 0.0256d;
        public override double atomicWeight { get; } = 197.00183d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new AlphaParticle(8629047.4), new Polonium193() } },

        };
    }
}
    
    