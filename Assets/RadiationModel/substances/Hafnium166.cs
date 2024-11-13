
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Hafnium166 : RadioactiveSubstance
    {
        public override string name { get; } = "Hafnium166";
        public override double halfLife { get; } = 406.2d;
        public override double atomicWeight { get; } = 165.94218d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Lutetium166() } },

        };
    }
}
    
    