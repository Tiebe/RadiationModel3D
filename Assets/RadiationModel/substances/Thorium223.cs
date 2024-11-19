using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Thorium223 : RadioactiveSubstance
    {
        public override string name { get; } = "Thorium223";
        public override double halfLife { get; } = 0.6d;
        public override double atomicWeight { get; } = 223.02081d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new AlphaParticle(8588002.09), new Radium219() } },

        };
    }
}
    
    