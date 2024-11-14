using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Erbium167m : RadioactiveSubstance
    {
        public override string name { get; } = "Erbium167m";
        public override double halfLife { get; } = 2.269d;
        public override double atomicWeight { get; } = 166.93228d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(0.00597), new Erbium167() } },

        };
    }
}
    
    