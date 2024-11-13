
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Potassium36 : RadioactiveSubstance
    {
        public override string name { get; } = "Potassium36";
        public override double halfLife { get; } = 0.341d;
        public override double atomicWeight { get; } = 35.9813d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Argon36() } },

        };
    }
}
    
    