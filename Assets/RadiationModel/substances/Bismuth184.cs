using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Bismuth184 : RadioactiveSubstance
    {
        public override string name { get; } = "Bismuth184";
        public override double halfLife { get; } = 0.0066d;
        public override double atomicWeight { get; } = 184.00134d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new AlphaParticle(9235047.4), new Thallium180() } },

        };
    }
}
    
    