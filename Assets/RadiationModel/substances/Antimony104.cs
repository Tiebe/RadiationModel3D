
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Antimony104 : RadioactiveSubstance
    {
        public override string name { get; } = "Antimony104";
        public override double halfLife { get; } = 0.47d;
        public override double atomicWeight { get; } = 103.93634d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 0.07d, new List<RadioactiveSubstance> { new ProtonParticle(), new Tin103() } },

        };
    }
}
    
    