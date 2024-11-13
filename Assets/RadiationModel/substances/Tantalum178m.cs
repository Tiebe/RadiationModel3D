
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Tantalum178m : RadioactiveSubstance
    {
        public override string name { get; } = "Tantalum178m";
        public override double halfLife { get; } = 558.6d;
        public override double atomicWeight { get; } = 177.94579d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Hafnium178() } },

        };
    }
}
    
    