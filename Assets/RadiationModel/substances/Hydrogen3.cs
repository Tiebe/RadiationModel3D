
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Hydrogen3 : RadioactiveSubstance
    {
        public override string name { get; } = "Hydrogen3";
        public override double halfLife { get; } = 388781648.64d;
        public override double atomicWeight { get; } = 3.01605d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Helium3() } },

        };
    }
}
    
    