using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Francium202 : RadioactiveSubstance
    {
        public override string name { get; } = "Francium202";
        public override double halfLife { get; } = 0.372d;
        public override double atomicWeight { get; } = 202.00333d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new AlphaParticle(8408002.09), new Astatine198() } },

        };
    }
}
    
    