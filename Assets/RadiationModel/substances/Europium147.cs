
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Europium147 : RadioactiveSubstance
    {
        public override string name { get; } = "Europium147";
        public override double halfLife { get; } = 2082240.0d;
        public override double atomicWeight { get; } = 146.91675d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Samarium147() } },

            { 2.2000000000000003e-05d, new List<RadioactiveSubstance> { new AlphaParticle(), new Promethium143() } },

        };
    }
}
    
    