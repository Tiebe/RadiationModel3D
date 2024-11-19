using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Samarium148 : RadioactiveSubstance
    {
        public override string name { get; } = "Samarium148";
        public override double halfLife { get; } = 1.988087976e+23d;
        public override double atomicWeight { get; } = 147.91483d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new AlphaParticle(3008902.09), new Neodymium144() } },

        };
    }
}
    
    