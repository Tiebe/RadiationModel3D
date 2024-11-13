
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Osmium186 : RadioactiveSubstance
    {
        public override string name { get; } = "Osmium186";
        public override double halfLife { get; } = 6.3113904e+22d;
        public override double atomicWeight { get; } = 185.95384d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new AlphaParticle(), new Tungsten182() } },

        };
    }
}
    
    