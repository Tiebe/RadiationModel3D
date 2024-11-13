
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Lanthanum141 : RadioactiveSubstance
    {
        public override string name { get; } = "Lanthanum141";
        public override double halfLife { get; } = 14112.0d;
        public override double atomicWeight { get; } = 140.91097d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Cerium141() } },

        };
    }
}
    
    