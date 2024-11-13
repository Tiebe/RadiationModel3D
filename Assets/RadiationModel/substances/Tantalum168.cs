
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Tantalum168 : RadioactiveSubstance
    {
        public override string name { get; } = "Tantalum168";
        public override double halfLife { get; } = 120.0d;
        public override double atomicWeight { get; } = 167.94805d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Hafnium168() } },

        };
    }
}
    
    