using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Thorium229 : RadioactiveSubstance
    {
        public override string name { get; } = "Thorium229";
        public override double halfLife { get; } = 249804832032.0d;
        public override double atomicWeight { get; } = 229.03176d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new AlphaParticle(6187547.4), new Radium225() } },

        };
    }
}
    
    