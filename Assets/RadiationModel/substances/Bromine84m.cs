
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Bromine84m : RadioactiveSubstance
    {
        public override string name { get; } = "Bromine84m";
        public override double halfLife { get; } = 360.0d;
        public override double atomicWeight { get; } = 83.91683d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Krypton84() } },

        };
    }
}
    
    