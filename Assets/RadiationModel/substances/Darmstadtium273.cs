using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Darmstadtium273 : RadioactiveSubstance
    {
        public override string name { get; } = "Darmstadtium273";
        public override double halfLife { get; } = 0.00024d;
        public override double atomicWeight { get; } = 273.14846d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new AlphaParticle(12395047.4), new Hassium269() } },

        };
    }
}
    
    