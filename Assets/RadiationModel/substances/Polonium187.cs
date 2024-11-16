using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Polonium187 : RadioactiveSubstance
    {
        public override string name { get; } = "Polonium187";
        public override double halfLife { get; } = 0.0014d;
        public override double atomicWeight { get; } = 187.00303d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new AlphaParticle(8997002.09), new Lead183() } },

        };
    }
}
    
    