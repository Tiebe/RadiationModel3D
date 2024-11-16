using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Rhenium167 : RadioactiveSubstance
    {
        public override string name { get; } = "Rhenium167";
        public override double halfLife { get; } = 3.4d;
        public override double atomicWeight { get; } = 166.96261d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new AlphaParticle(6297002.09), new Tantalum163() } },

        };
    }
}
    
    