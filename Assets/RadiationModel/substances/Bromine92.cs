using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Bromine92 : RadioactiveSubstance
    {
        public override string name { get; } = "Bromine92";
        public override double halfLife { get; } = 0.314d;
        public override double atomicWeight { get; } = 91.93963d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 12536300.0), new Krypton92() } },

        };
    }
}
    
    