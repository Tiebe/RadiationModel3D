using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Actinium214 : RadioactiveSubstance
    {
        public override string name { get; } = "Actinium214";
        public override double halfLife { get; } = 8.2d;
        public override double atomicWeight { get; } = 214.00691d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.93d, new List<RadioactiveSubstance> { new AlphaParticle(8372047.399999999), new Francium210() } },
            { 0.07d, new List<RadioactiveSubstance> { new BetaParticle(1, 6340000.0), new Radium214() } },

        };
    }
}
    
    