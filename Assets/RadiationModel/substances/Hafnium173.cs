using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Hafnium173 : RadioactiveSubstance
    {
        public override string name { get; } = "Hafnium173";
        public override double halfLife { get; } = 84960.0d;
        public override double atomicWeight { get; } = 172.94051d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 1469000.0), new Lutetium173() } },

        };
    }
}
    
    