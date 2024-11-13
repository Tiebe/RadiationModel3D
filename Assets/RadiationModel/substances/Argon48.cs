
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Argon48 : RadioactiveSubstance
    {
        public override string name { get; } = "Argon48";
        public override double halfLife { get; } = 0.415d;
        public override double atomicWeight { get; } = 47.976d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Potassium48() } },

        };
    }
}
    
    