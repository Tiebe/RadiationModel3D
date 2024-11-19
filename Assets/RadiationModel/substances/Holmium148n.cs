using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Holmium148n : RadioactiveSubstance
    {
        public override string name { get; } = "Holmium148n";
        public override double halfLife { get; } = 0.00236d;
        public override double atomicWeight { get; } = 147.93875d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.0d, new List<RadioactiveSubstance> { new GammaParticle((940000.0, 0.00132)), new Holmium148() } },
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle((690000.0, 0.0018)), new Holmium148m() } },

        };
    }
}
    
    