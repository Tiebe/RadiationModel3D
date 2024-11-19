using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Thorium217 : RadioactiveSubstance
    {
        public override string name { get; } = "Thorium217";
        public override double halfLife { get; } = 0.00025d;
        public override double atomicWeight { get; } = 217.0131d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new AlphaParticle(10457002.09), new Radium213() } },

        };
    }
}
    
    