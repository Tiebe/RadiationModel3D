
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Mercury205 : RadioactiveSubstance
    {
        public override string name { get; } = "Mercury205";
        public override double halfLife { get; } = 308.4d;
        public override double atomicWeight { get; } = 204.97607d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Thallium205() } },

        };
    }
}
    
    