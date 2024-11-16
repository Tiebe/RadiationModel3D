using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Germanium85 : RadioactiveSubstance
    {
        public override string name { get; } = "Germanium85";
        public override double halfLife { get; } = 0.495d;
        public override double atomicWeight { get; } = 84.94297d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 10066000.0), new Arsenic85() } },

        };
    }
}
    
    