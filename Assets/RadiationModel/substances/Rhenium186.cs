using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Rhenium186 : RadioactiveSubstance
    {
        public override string name { get; } = "Rhenium186";
        public override double halfLife { get; } = 321278.4d;
        public override double atomicWeight { get; } = 185.95499d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.9253d, new List<RadioactiveSubstance> { new BetaParticle(-1, 1072700.0), new Osmium186() } },
            { 0.0747d, new List<RadioactiveSubstance> { new Tungsten186() } },

        };
    }
}
    
    