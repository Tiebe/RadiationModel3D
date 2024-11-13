
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Hafnium165 : RadioactiveSubstance
    {
        public override string name { get; } = "Hafnium165";
        public override double halfLife { get; } = 76.0d;
        public override double atomicWeight { get; } = 164.94457d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Lutetium165() } },

        };
    }
}
    
    