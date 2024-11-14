using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Uranium223 : RadioactiveSubstance
    {
        public override string name { get; } = "Uranium223";
        public override double halfLife { get; } = 6e-05d;
        public override double atomicWeight { get; } = 223.02797d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new AlphaParticle(10185047.4), new Thorium219() } },

        };
    }
}
    
    