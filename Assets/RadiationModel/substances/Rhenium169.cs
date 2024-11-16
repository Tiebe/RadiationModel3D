using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Rhenium169 : RadioactiveSubstance
    {
        public override string name { get; } = "Rhenium169";
        public override double halfLife { get; } = 8.1d;
        public override double atomicWeight { get; } = 168.95877d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 5e-05d, new List<RadioactiveSubstance> { new AlphaParticle(6036002.09), new Tantalum165() } },

        };
    }
}
    
    