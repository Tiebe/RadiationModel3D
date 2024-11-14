using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Lutetium176 : RadioactiveSubstance
    {
        public override string name { get; } = "Lutetium176";
        public override double halfLife { get; } = 1.16792279352e+18d;
        public override double atomicWeight { get; } = 175.94269d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 1194100.0), new Hafnium176() } },
            { 0.0045000000000000005d, new List<RadioactiveSubstance> { new BetaParticle(1, 109022.0), new Ytterbium176() } },

        };
    }
}
    
    