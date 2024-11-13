
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Chlorine40 : RadioactiveSubstance
    {
        public override string name { get; } = "Chlorine40";
        public override double halfLife { get; } = 81.0d;
        public override double atomicWeight { get; } = 39.97041d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Argon40() } },

        };
    }
}
    
    