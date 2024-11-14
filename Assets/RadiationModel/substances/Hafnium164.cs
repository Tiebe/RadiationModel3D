using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Hafnium164 : RadioactiveSubstance
    {
        public override string name { get; } = "Hafnium164";
        public override double halfLife { get; } = 111.0d;
        public override double atomicWeight { get; } = 163.94437d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 2824000.0), new Lutetium164() } },

        };
    }
}
    
    