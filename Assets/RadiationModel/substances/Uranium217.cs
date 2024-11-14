using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Uranium217 : RadioactiveSubstance
    {
        public override string name { get; } = "Uranium217";
        public override double halfLife { get; } = 0.00085d;
        public override double atomicWeight { get; } = 217.02466d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new AlphaParticle(9445047.4), new Thorium213() } },

        };
    }
}
    
    