
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Gadolinium135 : RadioactiveSubstance
    {
        public override string name { get; } = "Gadolinium135";
        public override double halfLife { get; } = 1.1d;
        public override double atomicWeight { get; } = 134.9525d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Europium135() } },

        };
    }
}
    
    