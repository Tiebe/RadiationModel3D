using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Lutetium172m : RadioactiveSubstance
    {
        public override string name { get; } = "Lutetium172m";
        public override double halfLife { get; } = 222.0d;
        public override double atomicWeight { get; } = 171.93914d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(0.02959, 41900.0), new Lutetium172() } },

        };
    }
}
    
    