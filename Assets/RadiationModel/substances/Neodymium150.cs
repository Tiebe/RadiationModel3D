using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Neodymium150 : RadioactiveSubstance
    {
        public override string name { get; } = "Neodymium150";
        public override double halfLife { get; } = 2.9347965360000003e+26d;
        public override double atomicWeight { get; } = 149.9209d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-2, 3371300.0), new Samarium150() } },

        };
    }
}
    
    