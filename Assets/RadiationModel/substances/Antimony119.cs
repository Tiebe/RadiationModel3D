using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Antimony119 : RadioactiveSubstance
    {
        public override string name { get; } = "Antimony119";
        public override double halfLife { get; } = 137484.0d;
        public override double atomicWeight { get; } = 118.90394d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new Tin119() } },

        };
    }
}
    
    