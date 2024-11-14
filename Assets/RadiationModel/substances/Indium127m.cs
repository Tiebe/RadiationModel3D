using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Indium127m : RadioactiveSubstance
    {
        public override string name { get; } = "Indium127m";
        public override double halfLife { get; } = 3.618d;
        public override double atomicWeight { get; } = 126.91789d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 6984000.0), new Tin127() } },

        };
    }
}
    
    