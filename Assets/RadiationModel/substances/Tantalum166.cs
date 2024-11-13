
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Tantalum166 : RadioactiveSubstance
    {
        public override string name { get; } = "Tantalum166";
        public override double halfLife { get; } = 34.4d;
        public override double atomicWeight { get; } = 165.95051d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Hafnium166() } },

        };
    }
}
    
    