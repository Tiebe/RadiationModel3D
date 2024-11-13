
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Krypton79 : RadioactiveSubstance
    {
        public override string name { get; } = "Krypton79";
        public override double halfLife { get; } = 126144.0d;
        public override double atomicWeight { get; } = 78.92008d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Bromine79() } },

        };
    }
}
    
    