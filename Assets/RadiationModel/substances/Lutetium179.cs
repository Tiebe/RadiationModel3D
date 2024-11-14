using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Lutetium179 : RadioactiveSubstance
    {
        public override string name { get; } = "Lutetium179";
        public override double halfLife { get; } = 16524.0d;
        public override double atomicWeight { get; } = 178.94733d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 1404000.0), new Hafnium179() } },

        };
    }
}
    
    