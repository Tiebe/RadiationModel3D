using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Francium197 : RadioactiveSubstance
    {
        public override string name { get; } = "Francium197";
        public override double halfLife { get; } = 0.0023d;
        public override double atomicWeight { get; } = 197.011d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new AlphaParticle(8912047.4), new Astatine193() } },

        };
    }
}
    
    