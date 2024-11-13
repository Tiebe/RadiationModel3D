
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Argon49 : RadioactiveSubstance
    {
        public override string name { get; } = "Argon49";
        public override double halfLife { get; } = 0.236d;
        public override double atomicWeight { get; } = 48.98169d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Potassium49() } },

        };
    }
}
    
    