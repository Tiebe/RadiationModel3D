
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Zirconium97 : RadioactiveSubstance
    {
        public override string name { get; } = "Zirconium97";
        public override double halfLife { get; } = 60296.4d;
        public override double atomicWeight { get; } = 96.91096d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Niobium97() } },

        };
    }
}
    
    