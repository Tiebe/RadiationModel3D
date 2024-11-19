using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Darmstadtium271m : RadioactiveSubstance
    {
        public override string name { get; } = "Darmstadtium271m";
        public override double halfLife { get; } = 0.0017d;
        public override double atomicWeight { get; } = 271.14602d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new AlphaParticle(11957002.09), new Hassium267() } },

        };
    }
}
    
    