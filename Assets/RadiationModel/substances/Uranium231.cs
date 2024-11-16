using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Uranium231 : RadioactiveSubstance
    {
        public override string name { get; } = "Uranium231";
        public override double halfLife { get; } = 362880.0d;
        public override double atomicWeight { get; } = 231.03629d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new Protactinium231() } },
            { 4e-05d, new List<RadioactiveSubstance> { new AlphaParticle(6596247.4), new Thorium227() } },

        };
    }
}
    
    