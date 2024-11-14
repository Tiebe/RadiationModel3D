using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Fluorine20 : RadioactiveSubstance
    {
        public override string name { get; } = "Fluorine20";
        public override double halfLife { get; } = 11.0062d;
        public override double atomicWeight { get; } = 19.99998d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 7024469.199999999), new Neon20() } },

        };
    }
}
    
    