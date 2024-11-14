using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Lutetium178 : RadioactiveSubstance
    {
        public override string name { get; } = "Lutetium178";
        public override double halfLife { get; } = 1704.0d;
        public override double atomicWeight { get; } = 177.94596d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 2097500.0), new Hafnium178() } },

        };
    }
}
    
    