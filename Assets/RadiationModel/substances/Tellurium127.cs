
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Tellurium127 : RadioactiveSubstance
    {
        public override string name { get; } = "Tellurium127";
        public override double halfLife { get; } = 33660.0d;
        public override double atomicWeight { get; } = 126.90523d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Iodine127() } },

        };
    }
}
    
    