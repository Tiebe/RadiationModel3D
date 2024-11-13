
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Indium128n : RadioactiveSubstance
    {
        public override string name { get; } = "Indium128n";
        public override double halfLife { get; } = 0.72d;
        public override double atomicWeight { get; } = 127.92066d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Tin128() } },

        };
    }
}
    
    