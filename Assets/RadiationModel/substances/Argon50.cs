
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Argon50 : RadioactiveSubstance
    {
        public override string name { get; } = "Argon50";
        public override double halfLife { get; } = 0.106d;
        public override double atomicWeight { get; } = 49.9858d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Potassium50() } },

        };
    }
}
    
    