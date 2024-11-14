using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Promethium147 : RadioactiveSubstance
    {
        public override string name { get; } = "Promethium147";
        public override double halfLife { get; } = 82786507.8768d;
        public override double atomicWeight { get; } = 146.91514d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 224000.0), new Samarium147() } },

        };
    }
}
    
    