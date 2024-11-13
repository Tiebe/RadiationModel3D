
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Bromine85 : RadioactiveSubstance
    {
        public override string name { get; } = "Bromine85";
        public override double halfLife { get; } = 174.0d;
        public override double atomicWeight { get; } = 84.91565d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Krypton85() } },

        };
    }
}
    
    