using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Europium151 : RadioactiveSubstance
    {
        public override string name { get; } = "Europium151";
        public override double halfLife { get; } = 1.4516197919999999e+26d;
        public override double atomicWeight { get; } = 150.91986d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new AlphaParticle(2985902.09), new Promethium147() } },

        };
    }
}
    
    