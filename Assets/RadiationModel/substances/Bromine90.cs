using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Bromine90 : RadioactiveSubstance
    {
        public override string name { get; } = "Bromine90";
        public override double halfLife { get; } = 1.91d;
        public override double atomicWeight { get; } = 89.93129d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 10959300.0), new Krypton90() } },

        };
    }
}
    
    