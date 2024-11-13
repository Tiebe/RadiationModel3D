
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Nickel52 : RadioactiveSubstance
    {
        public override string name { get; } = "Nickel52";
        public override double halfLife { get; } = 0.0418d;
        public override double atomicWeight { get; } = 51.97578d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Cobalt52() } },

        };
    }
}
    
    