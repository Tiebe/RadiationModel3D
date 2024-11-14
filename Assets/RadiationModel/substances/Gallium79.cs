using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Gallium79 : RadioactiveSubstance
    {
        public override string name { get; } = "Gallium79";
        public override double halfLife { get; } = 2.848d;
        public override double atomicWeight { get; } = 78.93285d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 6981600.0), new Germanium79() } },

        };
    }
}
    
    