using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Thallium177 : RadioactiveSubstance
    {
        public override string name { get; } = "Thallium177";
        public override double halfLife { get; } = 0.018d;
        public override double atomicWeight { get; } = 176.99641d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.73d, new List<RadioactiveSubstance> { new AlphaParticle(8089002.09), new Gold173() } },

        };
    }
}
    
    