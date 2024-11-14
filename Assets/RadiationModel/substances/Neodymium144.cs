using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Neodymium144 : RadioactiveSubstance
    {
        public override string name { get; } = "Neodymium144";
        public override double halfLife { get; } = 7.2265420079999996e+22d;
        public override double atomicWeight { get; } = 143.91009d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new AlphaParticle(2921247.4000000004), new Cerium140() } },

        };
    }
}
    
    