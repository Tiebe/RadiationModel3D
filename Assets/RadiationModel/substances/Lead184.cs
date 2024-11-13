
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Lead184 : RadioactiveSubstance
    {
        public override string name { get; } = "Lead184";
        public override double halfLife { get; } = 0.49d;
        public override double atomicWeight { get; } = 183.98814d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 0.8d, new List<RadioactiveSubstance> { new AlphaParticle(), new Mercury180() } },

        };
    }
}
    
    