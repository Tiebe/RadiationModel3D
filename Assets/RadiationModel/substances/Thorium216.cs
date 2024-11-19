using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Thorium216 : RadioactiveSubstance
    {
        public override string name { get; } = "Thorium216";
        public override double halfLife { get; } = 0.02628d;
        public override double atomicWeight { get; } = 216.01106d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new AlphaParticle(9095002.09), new Radium212() } },

        };
    }
}
    
    