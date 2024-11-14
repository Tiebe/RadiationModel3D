using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Flerovium289 : RadioactiveSubstance
    {
        public override string name { get; } = "Flerovium289";
        public override double halfLife { get; } = 2.1d;
        public override double atomicWeight { get; } = 289.19052d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new AlphaParticle(10975047.4), new Copernicium285() } },

        };
    }
}
    
    