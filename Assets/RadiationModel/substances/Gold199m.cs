using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Gold199m : RadioactiveSubstance
    {
        public override string name { get; } = "Gold199m";
        public override double halfLife { get; } = 0.00044d;
        public override double atomicWeight { get; } = 198.96936d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle((548900.00001, 0.00226)), new Gold199() } },

        };
    }
}
    
    