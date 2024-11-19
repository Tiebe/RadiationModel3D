using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Thorium212 : RadioactiveSubstance
    {
        public override string name { get; } = "Thorium212";
        public override double halfLife { get; } = 0.0317d;
        public override double atomicWeight { get; } = 212.013d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new AlphaParticle(8980002.09), new Radium208() } },

        };
    }
}
    
    