using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Lutetium164 : RadioactiveSubstance
    {
        public override string name { get; } = "Lutetium164";
        public override double halfLife { get; } = 188.4d;
        public override double atomicWeight { get; } = 163.94134d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 6370000.0), new Ytterbium164() } },

        };
    }
}
    
    