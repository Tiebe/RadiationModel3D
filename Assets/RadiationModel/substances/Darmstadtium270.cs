using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Darmstadtium270 : RadioactiveSubstance
    {
        public override string name { get; } = "Darmstadtium270";
        public override double halfLife { get; } = 0.0002d;
        public override double atomicWeight { get; } = 270.14458d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new AlphaParticle(12135047.4), new Hassium266() } },

        };
    }
}
    
    