using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Samarium147 : RadioactiveSubstance
    {
        public override string name { get; } = "Samarium147";
        public override double halfLife { get; } = 3.3639710832e+18d;
        public override double atomicWeight { get; } = 146.9149d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new AlphaParticle(3333302.0900000003), new Neodymium143() } },

        };
    }
}
    
    