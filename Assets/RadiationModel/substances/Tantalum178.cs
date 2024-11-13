
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Tantalum178 : RadioactiveSubstance
    {
        public override string name { get; } = "Tantalum178";
        public override double halfLife { get; } = 8496.0d;
        public override double atomicWeight { get; } = 177.94568d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Hafnium178() } },

        };
    }
}
    
    