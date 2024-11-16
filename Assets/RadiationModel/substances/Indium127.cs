using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Indium127 : RadioactiveSubstance
    {
        public override string name { get; } = "Indium127";
        public override double halfLife { get; } = 1.086d;
        public override double atomicWeight { get; } = 126.91747d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 6590000.0), new Tin127() } },

        };
    }
}
    
    