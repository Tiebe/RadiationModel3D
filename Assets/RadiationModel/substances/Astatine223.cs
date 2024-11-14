using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Astatine223 : RadioactiveSubstance
    {
        public override string name { get; } = "Astatine223";
        public override double halfLife { get; } = 50.0d;
        public override double atomicWeight { get; } = 223.02515d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 3038000.0), new Radon223() } },

        };
    }
}
    
    