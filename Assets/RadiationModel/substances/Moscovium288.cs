using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Moscovium288 : RadioactiveSubstance
    {
        public override string name { get; } = "Moscovium288";
        public override double halfLife { get; } = 0.177d;
        public override double atomicWeight { get; } = 288.19288d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new AlphaParticle(11677002.09), new Nihonium284() } },

        };
    }
}
    
    