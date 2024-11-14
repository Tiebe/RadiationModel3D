using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Iridium193n : RadioactiveSubstance
    {
        public override string name { get; } = "Iridium193n";
        public override double halfLife { get; } = 0.00012d;
        public override double atomicWeight { get; } = 192.96537d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(0.00054), new Iridium193() } },

        };
    }
}
    
    