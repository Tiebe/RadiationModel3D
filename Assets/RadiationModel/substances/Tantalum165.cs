
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Tantalum165 : RadioactiveSubstance
    {
        public override string name { get; } = "Tantalum165";
        public override double halfLife { get; } = 31.0d;
        public override double atomicWeight { get; } = 164.95078d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Hafnium165() } },

        };
    }
}
    
    