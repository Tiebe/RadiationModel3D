using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Darmstadtium271 : RadioactiveSubstance
    {
        public override string name { get; } = "Darmstadtium271";
        public override double halfLife { get; } = 0.144d;
        public override double atomicWeight { get; } = 271.14595d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.75d, new List<RadioactiveSubstance> {  } },
            { 0.25d, new List<RadioactiveSubstance> { new AlphaParticle(11887002.09), new Hassium267() } },

        };
    }
}
    
    