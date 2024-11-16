using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Radon195 : RadioactiveSubstance
    {
        public override string name { get; } = "Radon195";
        public override double halfLife { get; } = 0.007d;
        public override double atomicWeight { get; } = 195.00542d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new AlphaParticle(8716002.09), new Polonium191() } },

        };
    }
}
    
    