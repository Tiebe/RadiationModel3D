
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Lead186 : RadioactiveSubstance
    {
        public override string name { get; } = "Lead186";
        public override double halfLife { get; } = 4.82d;
        public override double atomicWeight { get; } = 185.98424d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 0.4d, new List<RadioactiveSubstance> { new AlphaParticle(), new Mercury182() } },

        };
    }
}
    
    