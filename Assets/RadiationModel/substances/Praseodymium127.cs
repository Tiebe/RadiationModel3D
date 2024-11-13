
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Praseodymium127 : RadioactiveSubstance
    {
        public override string name { get; } = "Praseodymium127";
        public override double halfLife { get; } = 4.2d;
        public override double atomicWeight { get; } = 126.93071d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Cerium127() } },

        };
    }
}
    
    